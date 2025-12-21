# Anno Modding Translator

This project is not affiliated in any way with Ubisoft.

Anno 1800 is a trademark of Ubisoft Entertainment in the US and/or other countries. Anno is a trademark of Ubisoft GmbH in the US and/or other countries.

## Feature Overview

- [Autotranslate: Modinfo](#autotranslate-modinfo)
  - Translates the 4 multilang-categorys of modinfo into the corresponding language, if filled
- [Autotranslate: Single File](#autotranslate-single-file)
  - Translates the current File into the filename language
- [Autotranslate: from This](#autotranslate-from-this)
  - Translates from the current File into the anno-aviable languages

---

## Limits

While I currently used API-Key free API to get the translations, they might fail due to various reasons. While i tried to make some fail-safes it is not 100% and can break. Some of these translationservices have a hard limit, which i didn't encountered currently, but might change in the future, or the service might get deleted without my notice.

## Setup

After installing the plugin it should automatically detect modinfo and Texts. There is no fail-safe, you can trick it, while it produces a lot of errors...

### Properties / Settings

#### Translation
##### Lang
- default "en"

used for hover translations / maybe input to some languages
##### Provider
- default "Bing"

note that only Bing provides real batches, every other language will take more time if used in a batch
#### Comment

##### Source String
-default "false"

enables or disables to add the source string with the detected language

##### enable
- default "false"

if set, enables to add a comment to every translated \<Text\> with content of Text

##### text
- default "MachineTranslated by Nyk"

Which text should be used as a comment

#### Google

##### Key
https://aistudio.google.com/app/apikey

used for hover - better text, the free variant doesn't require a creditcard, only an google account, but its only in english. It uses the Hover Language to translate back and forth

---

## Shortcuts
| Keybind | Command |
| --- | --- |
| ctrl+alt+t | Autotranslate: Modinfo |
| ctrl+alt+z | Autotranslate: Single File |
| ctrl+alt+y | Autotranslate: from File |

---
## Feature Details

### Autotranslate: Modinfo

Can be either invoked by right click on the modinfo.json, shortcut or with the VSC Command palette.

It takes the corresponding text of the given category and translates it to the language of the same line.

Example: `"German": "Airship"` In this example only the word Airship will be taken and translated to German: `"German": "Luftschiff"`, while it tries to detect the language it might happen that a short sentence of the same language might get translated if the given sample is to short.

### Autotranslate: Single File

Asynchronus Task, you can run multiple at the same time, but its getting lots of errors in my tests. If you want to translate into multiple languages at once use the Batchcommand,

Translates the \<Text\> of a single document. The translation is trying to autodetect the given language and will translate it to the language of the filename.

### Autotranslate: from This

Choose the file which you want as a source for Batchtranslation into other languages. It will ask if its for all languages or not. If chosen to translate into all languages it will override existing files.