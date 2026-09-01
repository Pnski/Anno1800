from pathlib import Path

import ctranslate2
from huggingface_hub import snapshot_download
from ctranslate2.converters import TransformersConverter
from transformers import AutoTokenizer

import xml.etree.ElementTree as ET

modelName = {
    'base': 'Helsinki-NLP',
    "cn": "opus-mt-en-zh",
    "fr": "opus-mt-en-fr",
    "de": "opus-mt-en-de",
    "it": "opus-mt-en-it",
    "ja": "opus-mt-en-ja",
    "kr": "opus-mt-en-ko",
    "po": "opus-mt-en-pl",
    "ru": "opus-mt-en-ru",
    "sp": "opus-mt-en-es",
}

dirs = {
    'base': Path(__file__).resolve().parent,
    'dl': 'downloads',
    'models' :'models'
}


def download_model(L_CODE):
    MODEL_NAME = modelName['base']+ '/' + modelName[L_CODE]
    print(f"Downloading {MODEL_NAME}...")

    snapshot_download(
        repo_id=MODEL_NAME,
        local_dir=str(dirs['base'] /  dirs['dl'] / L_CODE),
    )


def convert_model(L_CODE):
    print("Converting model to CTranslate2 format...")

    converter = TransformersConverter(
        str(dirs['base']/ dirs['dl'] / L_CODE),
    )

    converter.convert(
        str(dirs['base']/ dirs['models'] / L_CODE),
        #quantization="int8",
    )


def get_translator(L_CODE):
    model_file = dirs['base'] / dirs['models'] / L_CODE / "model.bin"

    if not model_file.exists():

        if not (dirs['base']/ dirs['dl'] / L_CODE).exists():
            download_model(L_CODE)

        convert_model(L_CODE)

    print("Loading translation model...")

    translator = ctranslate2.Translator(
        str(dirs['base'] / dirs['models'] / L_CODE),
        device="cpu",
    )

    tokenizer = AutoTokenizer.from_pretrained(
        str(dirs['base']/ dirs['dl'] /L_CODE)
    )

    return translator, tokenizer


def main():

    for L_CODE in [
        "cn",
        "fr",
        "de",
        "it",
        "ja",
        "kr",
        "po",
        "ru",
        "sp",
    ]:

        translator, tokenizer = get_translator(L_CODE)

        input_file = dirs['base'] / "english.xml"
        output_file = dirs['base'] / f"{L_CODE}.xml"

        parser = ET.XMLParser(
            target=ET.TreeBuilder(insert_comments=True)
        )

        tree = ET.parse(input_file, parser=parser)
        root = tree.getroot()

        text_elements = root.findall(".//Text/Text")

        texts = [
            element.text or ""
            for element in text_elements
        ]

        print(f"Translating {len(texts)} texts to {L_CODE}...")

        encoded = tokenizer(
            texts,
            padding=False,
            truncation=False,
        )

        tokens = [
            tokenizer.convert_ids_to_tokens(ids)
            for ids in encoded["input_ids"]
        ]

        results = translator.translate_batch(tokens)

        for element, result in zip(text_elements, results):

            output_tokens = result.hypotheses[0]

            output_ids = tokenizer.convert_tokens_to_ids(
                output_tokens
            )

            translated = tokenizer.decode(
                output_ids,
                skip_special_tokens=True,
            )

            element.text = translated

        tree.write(
            output_file,
            encoding="utf-8",
            xml_declaration=True,
        )

        print(f"Written: {output_file}")

if __name__ == "__main__":
    main()