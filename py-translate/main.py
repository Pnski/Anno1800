from pathlib import Path
import time
from contextlib import redirect_stdout, redirect_stderr

import re
import html

import copy

import xml.etree.ElementTree as ET

import torch
from huggingface_hub import snapshot_download
from transformers import AutoModelForSeq2SeqLM, AutoTokenizer

# --------------------------------------------------
# Configuration
# --------------------------------------------------

MODEL_ID = "facebook/nllb-200-distilled-600M"

# https://huggingface.co/facebook/m2m100_418M
# https://huggingface.co/facebook/m2m100_1.2B
# https://huggingface.co/facebook/mbart-large-50-many-to-many-mmt

# The important distinction is that forced_bos_token_id is a generic generation mechanism, not a guarantee that a model has meaningful language-selection tokens. The model architecture must support generation with it, and the token ID must be valid for that model’s tokenizer.

# NLLB
# forced_bos_token_id = tokenizer.convert_tokens_to_ids("fra_Latn")

# M2M-100
# forced_bos_token_id = tokenizer.get_lang_id("fr")

# mBART-50
# forced_bos_token_id = tokenizer.lang_code_to_id["fr_XX"]

SCRIPT_DIR = Path(__file__).resolve().parent

# config file
CONFIG_FILE = "config.json"

MODELS = {
    "600M": "facebook/nllb-200-distilled-600M",
    "1.3B": "facebook/nllb-200-distilled-1.3B",
}

# NLLB Language Codes

LANGUAGES = {
    "chinese": "zho_Hans",  # Simplified Chinese
    "english": "eng_Latn",  # English
    "french": "fra_Latn",  # French
    "german": "deu_Latn",  # German
    "italian": "ita_Latn",  # Italian
    "japanese": "jpn_Jpan",  # Japanese
    "korean": "kor_Hang",  # Korean
    "polish": "pol_Latn",  # Polish
    "russian": "rus_Cyrl",  # Russian
    "spanish": "spa_Latn",  # Spanish
    "taiwanese": "zho_Hant",  # Traditional Chinese
    #"dutch": "nld_Latn",  # Hiero - Dutch :>
}

# --------------------------------------------------
# Model
# --------------------------------------------------

class SignalWriter:
    """File-like object that forwards writes as Worker.message signals."""
    def __init__(self, emit_line):
        self.emit_line = emit_line
        self._buffer = ""

    def write(self, s):
        self._buffer += s
        while "\r" in self._buffer or "\n" in self._buffer:
            idx_candidates = [i for i in (self._buffer.find("\r"), self._buffer.find("\n")) if i != -1]
            idx = min(idx_candidates)
            line, self._buffer = self._buffer[:idx].strip(), self._buffer[idx + 1:]
            if line:
                self.emit_line(line)

    def flush(self):
        pass


def get_model(model_type: str):

    cPath = Path(__file__).resolve().parent

    modelDirectory = cPath / model_type

    if not modelDirectory.exists() or not any(modelDirectory.iterdir()):
        print("Downloading model...")
        snapshot_download(
            repo_id=MODEL_ID,
            local_dir=str(modelDirectory),
            token=None,
        )

    tokenizer = AutoTokenizer.from_pretrained(
        modelDirectory,
        local_files_only=True,
    )

    model = AutoModelForSeq2SeqLM.from_pretrained(
        modelDirectory,
        local_files_only=True,
        #dtype=torch.float16 if device == "cuda" else torch.float32,
    )

    model.to("cuda" if torch.cuda.is_available() else "cpu")
    model.eval()  # model switch to drop TRAINING

    # so, model.train() and model.eval() have effect only on Layers, not on gradients, by default grad comp is switch on, but using context manager torch.no_grad() during evaluation allows you easily turn off and then autimatically turn on gradients comp at the end

    return model, tokenizer

# --------------------------------------------------
# Generate function
# --------------------------------------------------

def generate_tokens(model, tokenizer, texts: list[str], sLang:str, tLang:str) -> torch.Tensor:

    tokenizer.src_lang = sLang

    inputs = tokenizer(
        texts,
        return_tensors="pt",
        truncation=True,
        padding=True,
    )

    inputs = {name: value.to("cuda" if torch.cuda.is_available() else "cpu") for name, value in inputs.items()}

    with torch.no_grad():
        gToken = model.generate(
            **inputs,
            forced_bos_token_id=tokenizer.convert_tokens_to_ids(tLang),
            #max_new_tokens=128,
            no_repeat_ngram_size=3,
            repetition_penalty=1.3,
            num_beams=4,
        )

    return gToken

# --------------------------------------------------
# Decode function
# --------------------------------------------------

def decode_tokens(tokenizer, gToken: torch.Tensor) -> list[str]:
    return tokenizer.batch_decode(
        gToken,
        skip_special_tokens=True,
        clean_up_tokenization_spaces=False,
    )


# --------------------------------------------------
# html preserving
# --------------------------------------------------

TAG_RE = re.compile(r"(<[^>]+>)")


def parse_segments(raw: str):
    """
    Split text into ordered segments:
      ("tag", content)      -- an HTML/XML-like tag, left untouched
      ("literal", content)  -- whitespace-only text, left untouched
      ("text", [sentences]) -- real text, split into sentences for translation
    """
    segments = []
    for part in TAG_RE.split(raw):
        if not part:
            continue
        if TAG_RE.fullmatch(part):
            segments.append(("tag", part))
        elif not part.strip():
            segments.append(("literal", part))
        else:
            sentences = [s for s in re.split(r"(?<=[.!?])\s+", part.strip()) if s]
            segments.append(("text", sentences))
    return segments


def translate_element_text(model, tokenizer, raw: str, sLang: str, tLang: str) -> str:
    """
    Translate only the natural-language parts of `raw`; any HTML/XML-like
    tags (<p>, </b>, <br/>, ...) and pure whitespace pass through unchanged.
    """
    segments = parse_segments(raw)
    all_sentences = [s for kind, content in segments if kind == "text" for s in content]

    if not all_sentences:
        return raw  # nothing translatable (tags/whitespace only)

    gToken = generate_tokens(model, tokenizer, all_sentences, sLang, tLang)
    translated_flat = decode_tokens(tokenizer, gToken)
    translated_iter = iter(translated_flat)

    parts = []
    for kind, content in segments:
        if kind == "text":
            count = len(content)
            parts.append(" ".join(next(translated_iter) for _ in range(count)))
        else:
            parts.append(content)
    return "".join(parts)

# --------------------------------------------------
# GUI
# --------------------------------------------------

from PyQt6.QtCore import QThread, pyqtSignal
from PyQt6.QtWidgets import (
    QApplication,
    QWidget,
    QComboBox,
    QPushButton,
    QPlainTextEdit,
    QProgressBar,
    QLabel,
    QFileDialog,
    QGridLayout,
)

class MainWindow(QWidget):
    def __init__(self):
        super().__init__()

        self.setWindowTitle("Anno Translator")
        self.resize(700, 400)

        self.iXML = None #xml content
        self.iFile = None #fileName for Languagedetection
        self.oPath = None #outputfolder
        self.worker = None

        # Top row
        self.dropdown = QComboBox()
        self.dropdown.addItems(MODELS.values())

        self.open_file_button = QPushButton("Open .xml Texts-Source")
        self.open_file_button.clicked.connect(self.open_source)

        # Printout area
        self.printout_text = QPlainTextEdit()
        self.printout_text.setReadOnly(True)
        self.printout_text.setPlaceholderText(
            """
            Optional: Select different Model
            Select Source XML
            Select Output Folder
            Hit Start
            """
        )

        # Progress widgets
        self.progress_bar = QProgressBar()
        self.progress_bar.setRange(0, 100)

        self.progress_label = QLabel("[0/0] done")

        # Buttons
        self.open_folder_button = QPushButton("Select Output Folder")
        self.open_folder_button.setEnabled(False)
        self.open_folder_button.clicked.connect(self.open_folder)

        self.start_button = QPushButton("Start")
        self.start_button.setEnabled(False)
        self.start_button.clicked.connect(self.start_process)

        # Main layout
        layout = QGridLayout(self)

        # Row 0
        layout.addWidget(self.dropdown, 0, 0)
        layout.addWidget(self.open_file_button, 0, 1)

        # Row 1
        layout.addWidget(self.printout_text, 1, 0, 1, 2)

        # Row 2, left side: progress bar and [x/y] label
        progress_layout = QGridLayout()
        progress_layout.addWidget(self.progress_bar, 0, 0)
        progress_layout.addWidget(self.progress_label, 0, 1)

        layout.addLayout(progress_layout, 2, 0)

        # Row 2, right side: buttons
        buttons_layout = QGridLayout()
        buttons_layout.addWidget(self.open_folder_button, 0, 0)
        buttons_layout.addWidget(self.start_button, 0, 1)

        layout.addLayout(buttons_layout, 2, 1)

        # Resize behavior
        layout.setRowStretch(1, 1)
        layout.setColumnStretch(0, 1)
        layout.setColumnStretch(1, 1)

    def open_source(self):
        fPath, _ = QFileDialog.getOpenFileName(
            self,
            "Open File",
            "",
            "xml (*.xml)",
        )

        if fPath:
            self.iFile = fPath

            parser = ET.XMLParser(
                target=ET.TreeBuilder(insert_comments=True)
            )

            self.iXML = ET.parse(fPath, parser=parser)

            for c, texts in enumerate(self.iXML.getroot().findall(".//Text/Text")):
                self.printout_text.appendPlainText(texts.text)
                if c > 15: #print only the first 15 elements
                    break

            self.open_folder_button.setEnabled(True)

    def open_folder(self):
        oFolder = QFileDialog.getExistingDirectory(
            self,
            "Select Output Folder",
        )

        if oFolder:
            self.oPath = oFolder
            self.printout_text.appendPlainText(
                f"Selected output folder: {oFolder}"
            )
            self.start_button.setEnabled(True)

    def start_process(self):
        if self.worker and self.worker.isRunning():
            return

        self.printout_text.clear()
        self.progress_bar.setValue(0)
        self.start_button.setEnabled(False)

        self.worker = Worker(model=self.dropdown.currentText(), iXML=self.iXML,iFile=self.iFile, oFolder=self.oPath)
        self.worker.progress_changed.connect(self.update_progress)
        self.worker.message.connect(self.printout_text.appendHtml)
        self.worker.finished.connect(self.process_finished)
        self.worker.start()

    def update_progress(self, current, total):
        percentage = int((current / total) * 100)

        self.progress_bar.setValue(percentage)
        self.progress_label.setText(f"[{current}/{total}] done")

    def process_finished(self):
        self.printout_text.appendHtml("<p style='color:green'>Finished all translations.</p>")
        self.start_button.setEnabled(True)

class Worker(QThread):
    progress_changed = pyqtSignal(int, int)
    message = pyqtSignal(str)
    finished = pyqtSignal()

    def __init__(self, model, iXML, iFile, oFolder, parent=None):
        super().__init__(parent)
        self.model_name = model
        self.iXML = iXML
        self.iFile = iFile
        self.oFolder = oFolder

    def run(self):

        self.message.emit("Loading model (downloading if needed, this can take a while)...")
        self.progress_bar_busy = True
        writer = SignalWriter(lambda line: self.message.emit(line))

        with redirect_stdout(writer), redirect_stderr(writer):
            self.model, self.tokenizer = get_model(self.model_name)

        texts = self.iXML.getroot().findall(".//Text/Text")
        texts_len = len(texts)

        self.message.emit(f"{texts_len} Text to Translate")

        filename = Path(self.iFile).name
        language = filename.removeprefix("texts_").removesuffix(".xml")

        sLang = LANGUAGES[language.lower()]
        self.message.emit(f"Source language (from filename): {sLang}")

        key_by_code = {code: key for key, code in LANGUAGES.items()}
        difLang = [value for value in LANGUAGES.values() if value != sLang]

        # Pre-split every source text into sentences once, reused for every target language
        original_sentences = [
            [s for s in re.split(r"(?<=[.!?])\s+", text.text.strip()) if s]
            for text in texts
        ]

        total_steps = texts_len * len(difLang)
        step = 0
        self.progress_changed.emit(0, total_steps)

        for tLang in difLang:
            lang_key = key_by_code[tLang]
            translation_start = time.perf_counter()
            self.message.emit(f"Translating to {lang_key} ({tLang})...")

            tree_copy = copy.deepcopy(self.iXML)
            out_texts = tree_copy.getroot().findall(".//Text/Text")

            for text_el, source_text in zip(out_texts, texts):
                raw = source_text.text or ""
                translated = translate_element_text(self.model, self.tokenizer, raw, sLang, tLang)
                text_el.text = translated

                self.message.emit(f"<p style='color:red'>Input: {html.escape(raw)}</p>")
                self.message.emit(f"Output: {html.escape(translated)}")
                step += 1
                self.progress_changed.emit(step, total_steps)

            duration = time.perf_counter() - translation_start
            self.message.emit(f"Duration for {lang_key}: {duration:.2f}s")

            out_path = Path(self.oFolder) / f"texts_{lang_key}.xml"
            tree_copy.write(out_path, encoding="utf-8", xml_declaration=False)
            self.message.emit(f"<p style='color:red'>Wrote {out_path}</p>")

        self.finished.emit()

app = QApplication([])

window = MainWindow()
window.show()

app.exec()