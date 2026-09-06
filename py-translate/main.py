import copy
import gc
import html
import re
import sys
import time
import xml.etree.ElementTree as ET
from contextlib import redirect_stderr, redirect_stdout
from pathlib import Path

import torch
from huggingface_hub import snapshot_download
from transformers import AutoModelForSeq2SeqLM, AutoTokenizer

# --------------------------------------------------
# VERSION = 0.1.2
# --------------------------------------------------

# --------------------------------------------------
# REMINDERS
# --------------------------------------------------

# --------------------------------------------------
# Configuration
# --------------------------------------------------

MODELS = {
    "600M": "facebook/nllb-200-distilled-600M",
    "1.3B": "facebook/nllb-200-distilled-1.3B",
}

# NLLB Language Codes

LANGUAGES = {
    "Chinese": "zho_Hans",  # Simplified Chinese
    "English": "eng_Latn",  # English
    "French": "fra_Latn",  # French
    "German": "deu_Latn",  # German
    "Italian": "ita_Latn",  # Italian
    "Japanese": "jpn_Jpan",  # Japanese
    "Korean": "kor_Hang",  # Korean
    "Polish": "pol_Latn",  # Polish
    "Russian": "rus_Cyrl",  # Russian
    "Spanish": "spa_Latn",  # Spanish
    "Taiwanese": "zho_Hant",  # Traditional Chinese
}

# https://github.com/facebookresearch/flores/blob/main/flores200/README.md#languages-in-flores-200

ADD_LANGUAGES = {
    "Acehnese_Arabic_script": "ace_Arab",
    "Acehnese_Latin_script": "ace_Latn",
    "Mesopotamian_Arabic": "acm_Arab",
    "Ta_izzi-Adeni_Arabic": "acq_Arab",
    "Tunisian Arabic": "aeb_Arab",
    "Afrikaans": "afr_Latn",
    "South Levantine Arabic": "ajp_Arab",
    "Akan": "aka_Latn",
    "Amharic": "amh_Ethi",
    "North_Levantine_Arabic": "apc_Arab",
    "Modern_Standard_Arabic": "arb_Arab",
    "Modern_Standard_Arabic_Romanized": "arb_Latn",
    "Najdi_Arabic": "ars_Arab",
    "Moroccan_Arabic": "ary_Arab",
    "Egyptian_Arabic": "arz_Arab",
    "Assamese": "asm_Beng",
    "Asturian": "ast_Latn",
    "Awadhi": "awa_Deva",
    "Central_Aymara": "ayr_Latn",
    "South_Azerbaijani": "azb_Arab",
    "North_Azerbaijani": "azj_Latn",
    "Bashkir": "bak_Cyrl",
    "Bambara": "bam_Latn",
    "Balinese": "ban_Latn",
    "Belarusian": "bel_Cyrl",
    "Bemba": "bem_Latn",
    "Bengali": "ben_Beng",
    "Bhojpuri": "bho_Deva",
    "Banjar (Arabic script)": "bjn_Arab",
    "Banjar (Latin script)": "bjn_Latn",
    "Standard Tibetan": "bod_Tibt",
    "Bosnian": "bos_Latn",
    "Buginese": "bug_Latn",
    "Bulgarian": "bul_Cyrl",
    "Catalan": "cat_Latn",
    "Cebuano": "ceb_Latn",
    "Czech": "ces_Latn",
    "Chokwe": "cjk_Latn",
    "Central Kurdish": "ckb_Arab",
    "Crimean Tatar": "crh_Latn",
    "Welsh": "cym_Latn",
    "Danish": "dan_Latn",
    #"German": "deu_Latn",
    "Southwestern Dinka": "dik_Latn",
    "Dyula": "dyu_Latn",
    "Dzongkha": "dzo_Tibt",
    "Greek": "ell_Grek",
    #"English": "eng_Latn",
    "Esperanto": "epo_Latn",
    "Estonian": "est_Latn",
    "Basque": "eus_Latn",
    "Ewe": "ewe_Latn",
    "Faroese": "fao_Latn",
    "Fijian": "fij_Latn",
    "Finnish": "fin_Latn",
    "Fon": "fon_Latn",
    #"French": "fra_Latn",
    "Friulian": "fur_Latn",
    "Nigerian Fulfulde": "fuv_Latn",
    "Scottish Gaelic": "gla_Latn",
    "Irish": "gle_Latn",
    "Galician": "glg_Latn",
    "Guarani": "grn_Latn",
    "Gujarati": "guj_Gujr",
    "Haitian Creole": "hat_Latn",
    "Hausa": "hau_Latn",
    "Hebrew": "heb_Hebr",
    "Hindi": "hin_Deva",
    "Chhattisgarhi": "hne_Deva",
    "Croatian": "hrv_Latn",
    "Hungarian": "hun_Latn",
    "Armenian": "hye_Armn",
    "Igbo": "ibo_Latn",
    "Ilocano": "ilo_Latn",
    "Indonesian": "ind_Latn",
    "Icelandic": "isl_Latn",
    #"Italian": "ita_Latn",
    "Javanese": "jav_Latn",
    #"Japanese": "jpn_Jpan",
    "Kabyle": "kab_Latn",
    "Jingpho": "kac_Latn",
    "Kamba": "kam_Latn",
    "Kannada": "kan_Knda",
    "Kashmiri_Arabic_script": "kas_Arab",
    "Kashmiri_Devanagari_script": "kas_Deva",
    "Georgian": "kat_Geor",
    "Central_Kanuri_Arabic_script": "knc_Arab",
    "Central_Kanuri_Latin_script": "knc_Latn",
    "Kazakh": "kaz_Cyrl",
    "Kabiyè": "kbp_Latn",
    "Kabuverdianu": "kea_Latn",
    "Khmer": "khm_Khmr",
    "Kikuyu": "kik_Latn",
    "Kinyarwanda": "kin_Latn",
    "Kyrgyz": "kir_Cyrl",
    "Kimbundu": "kmb_Latn",
    "Northern Kurdish": "kmr_Latn",
    "Kikongo": "kon_Latn",
    #"Korean": "kor_Hang",
    "Lao": "lao_Laoo",
    "Ligurian": "lij_Latn",
    "Limburgish": "lim_Latn",
    "Lingala": "lin_Latn",
    "Lithuanian": "lit_Latn",
    "Lombard": "lmo_Latn",
    "Latgalian": "ltg_Latn",
    "Luxembourgish": "ltz_Latn",
    "Luba-Kasai": "lua_Latn",
    "Ganda": "lug_Latn",
    "Luo": "luo_Latn",
    "Mizo": "lus_Latn",
    "Standard_Latvian": "lvs_Latn",
    "Magahi": "mag_Deva",
    "Maithili": "mai_Deva",
    "Malayalam": "mal_Mlym",
    "Marathi": "mar_Deva",
    "Minangkabau (Arabic script)": "min_Arab",
    "Minangkabau (Latin script)": "min_Latn",
    "Macedonian": "mkd_Cyrl",
    "Plateau Malagasy": "plt_Latn",
    "Maltese": "mlt_Latn",
    "Meitei (Bengali script)": "mni_Beng",
    "Halh Mongolian": "khk_Cyrl",
    "Mossi": "mos_Latn",
    "Maori": "mri_Latn",
    "Burmese": "mya_Mymr",
    "Dutch": "nld_Latn",
    "Norwegian Nynorsk": "nno_Latn",
    "Norwegian Bokmål": "nob_Latn",
    "Nepali": "npi_Deva",
    "Northern Sotho": "nso_Latn",
    "Nuer": "nus_Latn",
    "Nyanja": "nya_Latn",
    "Occitan": "oci_Latn",
    "West Central Oromo": "gaz_Latn",
    "Odia": "ory_Orya",
    "Pangasinan": "pag_Latn",
    "Eastern Panjabi": "pan_Guru",
    "Papiamento": "pap_Latn",
    "Western Persian": "pes_Arab",
    #"Polish": "pol_Latn",
    "Portuguese": "por_Latn",
    "Dari": "prs_Arab",
    "Southern Pashto": "pbt_Arab",
    "Ayacucho Quechua": "quy_Latn",
    "Romanian": "ron_Latn",
    "Rundi": "run_Latn",
    #"Russian": "rus_Cyrl",
    "Sango": "sag_Latn",
    "Sanskrit": "san_Deva",
    "Santali": "sat_Olck",
    "Sicilian": "scn_Latn",
    "Shan": "shn_Mymr",
    "Sinhala": "sin_Sinh",
    "Slovak": "slk_Latn",
    "Slovenian": "slv_Latn",
    "Samoan": "smo_Latn",
    "Shona": "sna_Latn",
    "Sindhi": "snd_Arab",
    "Somali": "som_Latn",
    "Southern Sotho": "sot_Latn",
    #"Spanish": "spa_Latn",
    "Tosk Albanian": "als_Latn",
    "Sardinian": "srd_Latn",
    "Serbian": "srp_Cyrl",
    "Swati": "ssw_Latn",
    "Sundanese": "sun_Latn",
    "Swedish": "swe_Latn",
    "Swahili": "swh_Latn",
    "Silesian": "szl_Latn",
    "Tamil": "tam_Taml",
    "Tatar": "tat_Cyrl",
    "Telugu": "tel_Telu",
    "Tajik": "tgk_Cyrl",
    "Tagalog": "tgl_Latn",
    "Thai": "tha_Thai",
    "Tigrinya": "tir_Ethi",
    "Tamasheq (Latin script)": "taq_Latn",
    "Tamasheq (Tifinagh script)": "taq_Tfng",
    "Tok Pisin": "tpi_Latn",
    "Tswana": "tsn_Latn",
    "Tsonga": "tso_Latn",
    "Turkmen": "tuk_Latn",
    "Tumbuka": "tum_Latn",
    "Turkish": "tur_Latn",
    "Twi": "twi_Latn",
    "Central Atlas Tamazight": "tzm_Tfng",
    "Uyghur": "uig_Arab",
    "Ukrainian": "ukr_Cyrl",
    "Umbundu": "umb_Latn",
    "Urdu": "urd_Arab",
    "Northern Uzbek": "uzn_Latn",
    "Venetian": "vec_Latn",
    "Vietnamese": "vie_Latn",
    "Waray": "war_Latn",
    "Wolof": "wol_Latn",
    "Xhosa": "xho_Latn",
    "Eastern Yiddish": "ydd_Hebr",
    "Yoruba": "yor_Latn",
    "Yue Chinese": "yue_Hant",
    #"Chinese (Simplified)": "zho_Hans",
    #"Chinese (Traditional)": "zho_Hant",
    "Standard Malay": "zsm_Latn",
    "Zulu": "zul_Latn",
}

# --------------------------------------------------
# Devices
# --------------------------------------------------


# device
if torch.xpu.is_available():  # intel ARC
    device = "xpu"  # torch.device("xpu")
elif torch.cuda.is_available():
    device = "cuda"  # torch.device("cuda")
else:
    device = "cpu"  # torch.device("cpu")


def list_available_devices() -> list[tuple[str, str]]:
    """
    Returns a list of (label, torch_device_string) tuples for every
    available compute device, CPU always included last as a fallback.
    """
    devices = []

    if torch.cuda.is_available():
        for i in range(torch.cuda.device_count()):
            name = torch.cuda.get_device_name(i)
            devices.append((f"CUDA:{i} — {name}", f"cuda:{i}"))

    if torch.xpu.is_available():
        for i in range(torch.xpu.device_count()):
            name = torch.xpu.get_device_name(i)
            devices.append((f"XPU:{i} — {name}", f"xpu:{i}"))

    devices.append(("CPU", "cpu"))
    return devices


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
            idx_candidates = [
                i for i in (self._buffer.find("\r"), self._buffer.find("\n")) if i != -1
            ]
            idx = min(idx_candidates)
            line, self._buffer = self._buffer[:idx].strip(), self._buffer[idx + 1 :]
            if line:
                self.emit_line(line)

    def flush(self):
        pass


def get_app_dir() -> Path:
    """
    Returns the directory the .exe lives in when frozen (PyInstaller --onefile),
    or the script's own directory when running as plain Python.
    """
    if getattr(sys, "frozen", False):
        return Path(sys.executable).resolve().parent
    return Path(__file__).resolve().parent

def get_model(model_type: str):

    cPath = get_app_dir()

    modelDirectory = cPath / model_type

    if not modelDirectory.exists() or not any(modelDirectory.iterdir()):
        print("Downloading model...")
        snapshot_download(
            repo_id=model_type,
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
        # dtype=torch.float16 if device == "cuda" else torch.float32,
    )

    model.to(device)
    model.eval()  # model switch to drop TRAINING

    return model, tokenizer


# --------------------------------------------------
# Generate function
# --------------------------------------------------


def generate_tokens(
    model, tokenizer, texts: list[str], sLang: str, tLang: str
) -> torch.Tensor:

    tokenizer.src_lang = sLang

    inputs = tokenizer(
        texts,
        return_tensors="pt",
        truncation=True,
        padding=True,
    )

    inputs = {name: value.to(device) for name, value in inputs.items()}

    with torch.no_grad():
        gToken = model.generate(
            **inputs,
            forced_bos_token_id=tokenizer.convert_tokens_to_ids(tLang),
            # max_new_tokens=128,
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

TAG_RE = re.compile(r"<[^>]+>")
PLACEHOLDER_RE = re.compile(r"\[(?:[^\[\]]|\[[^\[\]]*\])*\]")

SPLIT_RE = re.compile(f"({TAG_RE.pattern}|{PLACEHOLDER_RE.pattern})")


def parse_segments(raw: str):
    """
    Split text into ordered segments:
      ("tag", content)         -- an HTML/XML-like tag, left untouched
      ("placeholder", content) -- a [AssetData(...) ...] style token, left untouched
      ("literal", content)     -- whitespace-only text, left untouched
      ("text", [sentences])    -- real text, split into sentences for translation
    """
    segments = []
    for part in SPLIT_RE.split(raw):
        if not part:
            continue
        if TAG_RE.fullmatch(part):
            segments.append(("tag", part))
        elif PLACEHOLDER_RE.fullmatch(part):
            segments.append(("placeholder", part))
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

from PyQt6.QtCore import Qt, QThread, pyqtSignal
from PyQt6.QtWidgets import (
    QApplication,
    QComboBox,
    QFileDialog,
    QGridLayout,
    QLabel,
    QLineEdit,
    QListView,
    QListWidget,
    QListWidgetItem,
    QMessageBox,
    QPlainTextEdit,
    QProgressBar,
    QPushButton,
    QWidget,
)


class MainWindow(QWidget):
    def __init__(self):
        super().__init__()

        self.setWindowTitle("Anno Translator")
        self.resize(700, 400)

        self.iXML = None  # xml content
        self.iFile = None  # fileName for Languagedetection
        self.oPath = None  # outputfolder
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
        self.progress_bar.hide()

        self.progress_label = QLabel("[0/0] done")
        self.progress_label.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.progress_label.hide()

        self.texts_label = QLabel("")
        self.texts_label.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.file_label = QLabel("")
        self.file_label.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.folder_label = QLabel("")
        self.folder_label.setAlignment(Qt.AlignmentFlag.AlignCenter)

        self.open_folder_button = QPushButton("Select Output Folder")
        self.open_folder_button.hide()
        self.open_folder_button.clicked.connect(self.open_folder)

        #LANGUAGES
        self.lang_filter = QLineEdit()
        self.lang_filter.setPlaceholderText("Filter languages...")
        self.lang_filter.textChanged.connect(self.filter_languages)

        self.lang_list = QListWidget()
        self.lang_list.setSelectionMode(QListWidget.SelectionMode.NoSelection)

        # Flow top-to-bottom then wrap into new columns, scrolling sideways
        self.lang_list.setFlow(QListView.Flow.TopToBottom)
        self.lang_list.setWrapping(True)
        self.lang_list.setResizeMode(QListView.ResizeMode.Adjust)
        self.lang_list.setHorizontalScrollBarPolicy(Qt.ScrollBarPolicy.ScrollBarAsNeeded)
        self.lang_list.setVerticalScrollBarPolicy(Qt.ScrollBarPolicy.ScrollBarAlwaysOff)

        self.lang_list.setFixedHeight(24 * 8 + 10)

        ALL_LANGUAGES = {**LANGUAGES, **ADD_LANGUAGES}

        for key, code in ALL_LANGUAGES.items():
            item = QListWidgetItem(f"{key} ({code})")
            item.setData(Qt.ItemDataRole.UserRole, code)
            item.setFlags(item.flags() | Qt.ItemFlag.ItemIsUserCheckable)
            item.setCheckState(
                Qt.CheckState.Checked if key in LANGUAGES else Qt.CheckState.Unchecked
            )
            self.lang_list.addItem(item)

        self.start_button = QPushButton("Start Translation")
        self.start_button.hide()
        self.start_button.clicked.connect(self.start_process)

        self.cancel_button = QPushButton("Cancel Translation")
        self.cancel_button.hide()
        self.cancel_button.clicked.connect(self.cancel_process)

        self.dev_label = QLabel(f"Devices: {list_available_devices()}")
        self.dev_label.setAlignment(Qt.AlignmentFlag.AlignCenter)

        self.gpu_label = QLabel(f"CUDA Support: {torch.cuda.is_available()}")
        self.gpu_label.setAlignment(Qt.AlignmentFlag.AlignCenter)

        self.help_button = QPushButton("Help")
        self.help_button.clicked.connect(self.show_help)

        # Main layout
        layout = QGridLayout(self)

        # Row 0
        layout.addWidget(self.dropdown, 0, 0)
        layout.addWidget(self.open_file_button, 0, 1)
        layout.addWidget(self.open_folder_button, 0, 2)

        # Row 1
        layout.addWidget(self.texts_label, 1, 0)
        layout.addWidget(self.file_label, 1, 1)
        layout.addWidget(self.folder_label, 1, 2)

        # Row 2
        button_layout = QGridLayout()
        button_layout.addWidget(self.start_button,0,0)
        button_layout.addWidget(self.cancel_button,0,1)

        layout.addLayout(button_layout, 2, 0, 1, 3)

        # Row 3
        layout.addWidget(self.progress_bar, 3, 0, 1, 2)
        layout.addWidget(self.progress_label, 3, 2)

        # Row 4
        layout.addWidget(self.printout_text, 4, 0, 1, 3)

        # Row 5
        layout.addWidget(QLabel("Target Languages:"), 6, 0)
        layout.addWidget(self.lang_filter, 6, 1, 1, 2)
        layout.addWidget(self.lang_list, 7, 0, 1, 3)

        # Row 8
        layout.addWidget(self.dev_label, 8, 0)
        layout.addWidget(self.gpu_label, 8, 1)
        layout.addWidget(self.help_button, 8, 2)

        # Make the output area take the available vertical space
        layout.setRowStretch(4, 1)

        # Make all columns resize evenly
        layout.setColumnStretch(0, 1)
        layout.setColumnStretch(1, 1)
        layout.setColumnStretch(2, 1)

    def open_source(self):
        fPath, _ = QFileDialog.getOpenFileName(
            self,
            "Open File",
            "",
            "xml (*.xml)",
        )

        if fPath:
            self.iFile = fPath

            parser = ET.XMLParser(target=ET.TreeBuilder(insert_comments=True))

            try:
                self.printout_text.clear()
                self.iXML = ET.parse(fPath, parser=parser)

                texts = self.iXML.getroot().findall(".//Text/Text")

                assert len(texts) > 0, 'No Text Elements found!'

                self.printout_text.appendHtml(
                    "<p style='color:red'>FIRST 15 Texts:</p>"
                )

                for c, text in enumerate(texts):
                    self.printout_text.appendHtml(
                        f"<p style='color:orange'>{''.join(text.itertext())}</p>"
                    )
                    if c > 15:  # print only the first 15 elements
                        break

                self.texts_label.setText(f"{len(texts)!s} Texts found")
                self.file_label.setText(fPath)
                self.open_folder_button.show()
            except Exception as exc:  # noqa: BLE001
                self.printout_text.appendHtml(
                    f"<p style='color:red'>YOUR XML IS NOT VALID check for <code>&amp;</code> and like <code>&lt;/WhateverContainer&gt;</code>. Error {exc}</p>"
                )

    def open_folder(self):
        oFolder = QFileDialog.getExistingDirectory(
            self,
            "Select Output Folder",
        )

        if oFolder:
            self.oPath = oFolder
            self.folder_label.setText(oFolder)
            self.start_button.show()

    def show_help(self):
        message_box = QMessageBox(self)
        message_box.setWindowTitle("Help")
        message_box.setIcon(QMessageBox.Icon.Information)

        message_box.setTextFormat(Qt.TextFormat.RichText)
        message_box.setTextInteractionFlags(
            Qt.TextInteractionFlag.TextBrowserInteraction
        )
        message_box.setText(
            """
            <p>Device should be either <b>CUDA</b> or <b>XPU</b>.</p>

            <p>Expect slow results with CPU.</p>

            <p>If <b>Device: CUDA</b> is shown but it is still slow,
            install the CUDA package for Windows/Linux.</p>

            <p><a href="https://developer.nvidia.com/cuda/toolkit">
            NVIDIA HOMEPAGE</a></p>
            <p><a href="https://rocm.docs.amd.com/projects/radeon-ryzen/en/latest/docs/install/installrad/windows/install-pytorch.html">
            AMD HOMEPAGE</a></p>
            <p><a href="https://docs.pytorch.org/docs/2.14/notes/get_start_xpu.html">
            INTEL ARC</a></p>

            <p>If that still does not work, run Python through CMD or PowerShell.</p>
            """
        )

        message_box.exec()

    def get_checked_target_languages(self) -> list[str]:
        """Returns the list of NLLB language codes the user has checked."""
        codes = []
        for i in range(self.lang_list.count()):
            item = self.lang_list.item(i)
            if item.checkState() == Qt.CheckState.Checked:
                codes.append(item.data(Qt.ItemDataRole.UserRole))
        return codes

    def filter_languages(self, text: str):
        text = text.strip().lower()
        for i in range(self.lang_list.count()):
            item = self.lang_list.item(i)
            item.setHidden(text not in item.text().lower())

    def start_process(self):
        if self.worker and self.worker.isRunning():
            return

        self.printout_text.clear()
        self.progress_bar.setValue(0)
        self.start_button.setEnabled(False)
        self.cancel_button.show()
        self.cancel_button.setEnabled(True)
        self.progress_bar.show()
        self.progress_label.show()

        self.worker = Worker(
            model=self.dropdown.currentText(),
            iXML=self.iXML,
            iFile=self.iFile,
            oFolder=self.oPath,
            targetLanguages=self.get_checked_target_languages(),
        )
        self.worker.progress_changed.connect(self.update_progress)
        self.worker.message.connect(self.printout_text.appendHtml)
        self.worker.finished.connect(self.process_finished)
        self.worker.start()

    def cancel_process(self):
        if self.worker and self.worker.isRunning():
            self.worker.cancel()
            self.start_button.setEnabled(True)
            self.cancel_button.setEnabled(False)
            self.printout_text.appendHtml(
                "<p style='color:orange'>Cancelling — finishing current step...</p>"
            )

    def update_progress(self, current:int, total:int, cLang:str = ""):
        percentage = int((current / total) * 100)

        self.progress_bar.setValue(percentage)
        self.progress_label.setText(f"[{current}/{total}] done. Current Language: {cLang}")

    def process_finished(self, model, tokenizer):
        self.printout_text.appendHtml(
            "<p style='color:green'>Finished Process.</p>"
        )
        self.start_button.setEnabled(True)
        self.cancel_button.setEnabled(False)

        model.to("cpu")

        del model
        del tokenizer

        gc.collect()

        if torch.cuda.is_available():
            torch.cuda.empty_cache()
            torch.cuda.ipc_collect()

        self.worker = None

class Worker(QThread):
    progress_changed = pyqtSignal(int, int, str)
    message = pyqtSignal(str)
    finished = pyqtSignal(object, object)

    def __init__(self, model, iXML, iFile, oFolder, targetLanguages, parent=None):
        super().__init__(parent)
        self.model_name = model
        self.iXML = iXML
        self.iFile = iFile
        self.oFolder = oFolder
        self.targetLanguages = targetLanguages
        self._cancel = False

    def cancel(self):
        self._cancel = True

    def run(self):
        self.message.emit(
            "Loading model (downloading if needed, this can take a while)..."
        )
        self.progress_bar_busy = True
        writer = SignalWriter(lambda line: self.message.emit(line))

        with redirect_stdout(writer), redirect_stderr(writer):
            self.model, self.tokenizer = get_model(self.model_name)

        translation_start = time.perf_counter()

        texts = self.iXML.getroot().findall(".//Text/Text")
        texts_len = len(texts)

        fileLanguage = Path(self.iFile).name.removeprefix("texts_").removesuffix(".xml")

        sLang = {name.lower(): code for name, code in {**LANGUAGES, **ADD_LANGUAGES}.items()}[fileLanguage.lower()]
        self.message.emit(f"Source language (from filename): {sLang}")

        key_by_code = {code: key for key, code in {**LANGUAGES, **ADD_LANGUAGES}.items()}
        difLang = [code for code in self.targetLanguages if code != sLang]

        if not difLang:
            self.message.emit("<p style='color:red'>No target languages selected.</p>")
            self.finished.emit()
            return

        total_steps = texts_len * len(difLang)
        step = 0
        self.progress_changed.emit(0, total_steps, "")

        for tLang in difLang:
            if self._cancel:
                break

            lang_key = key_by_code[tLang]
            self.message.emit(f"Translating to {lang_key} ({tLang})...")

            tree_copy = copy.deepcopy(self.iXML)
            out_texts = tree_copy.getroot().findall(".//Text/Text")

            for text_el, source_text in zip(out_texts, texts):
                if self._cancel:
                    break
                raw = source_text.text or ""
                translated = translate_element_text(
                    self.model, self.tokenizer, raw, sLang, tLang
                )
                text_el.text = translated

                self.message.emit(
                    f"<p style='color:blue'>Input: {html.escape(raw)}</p>"
                )
                self.message.emit(f"Output: {html.escape(translated)}")
                step += 1
                self.progress_changed.emit(step, total_steps, next(
                    (key for key, value in {**LANGUAGES, **ADD_LANGUAGES}.items() if value == tLang),
                    None
                ))

            if not self._cancel:
                out_path = Path(self.oFolder) / f"texts_{lang_key.lower()}.xml"
                tree_copy.write(out_path, encoding="utf-8", xml_declaration=False)
                self.message.emit(f"<p style='color:green'>Wrote {out_path}</p>")

        duration = time.perf_counter() - translation_start
        self.message.emit(f"Translation took: {duration:.2f}s")

        self.finished.emit(self.model, self.tokenizer)


app = QApplication([])

window = MainWindow()
window.show()

app.exec()
