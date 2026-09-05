interface MyMemoryResponse {
	responseData: {
		translatedText: string;
		match: number;
	};
	responseStatus: number;
	responseDetails: string;
}

/**
 * Translate text using MyMemory.
 *
 * @param TranslateText Text to translate
 * @param TranslateTo Target language code
 * @param TranslateFrom Source language code. `auto` by default.
 *
 * @returns Promise<string | undefined>
 */
export async function singleTranslate(
	TranslateText: string,
	TranslateTo: string,
	TranslateFrom: string = "en"
): Promise<string | undefined> {

	const params = new URLSearchParams({
		q: TranslateText,
		langpair: `${TranslateFrom}|${TranslateTo}`
	});

	const url = `https://api.mymemory.translated.net/get?${params}`;

	const response = await fetch(url);

	if (!response.ok) {
		throw new Error(
			`MyMemory request failed: ${response.status} ${response.statusText}`
		);
	}

	const res: any = await response.json();

	if (res.responseStatus !== 200) {
		throw new Error(
			`MyMemory translation failed: ${res.responseDetails}`
		);
	}

	return res.responseData?.translatedText;
}


/**
 * Translate text to multiple languages using MyMemory.
 *
 * @param TranslateText Text to translate
 * @param TranslateTo Target language codes
 * @param TranslateFrom Source language code. `auto` by default.
 *
 * @returns Promise containing one translation per target language
 */
export async function multiTranslate(
	TranslateText: string,
	TranslateTo: string[],
	TranslateFrom: string = "en"
): Promise<Record<string, string>> {

	const translations: Record<string, string> = {};

	for (const target of TranslateTo) {
		const params = new URLSearchParams({
			q: TranslateText,
			langpair: `${TranslateFrom}|${target}`
		});

		const url = `https://api.mymemory.translated.net/get?${params}`;

		const response = await fetch(url);

		if (!response.ok) {
			throw new Error(
				`MyMemory request failed for ${target}: ` +
				`${response.status} ${response.statusText}`
			);
		}

		const res:any = await response.json();

		if (res.responseStatus !== 200) {
			throw new Error(
				`MyMemory translation failed for ${target}: ` +
				`${res.responseDetails}`
			);
		}

		translations[target] = res.responseData.translatedText;
	}

	return translations;
}