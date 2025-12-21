/* const get = require("got");
const URL = require("url"); */
/* const flat = require("flat");
const { get: getProp } = require("lodash");
const cheerio = require("cheerio"); */

import WMirrors from "./wiktionaryConfig";

export async function wiktionaryLookup(Word: string, Language: string): Promise<any> {
	var url = "https://" + Language + ".wiktionary.org/w/api.php";

	var params: { [key: string]: string } = {
		action: "query",
		format: "json",
		
		prop: "extracts",
		exchars:"150"+"&explaintext",
		formatversion: "2",
		//redirects: "1",
		
		titles: Word,
		//?action=query&prop=extracts&exchars=100&explaintext&titles=Mother&format=json
	};

	url = url + "?origin=*";
	Object.keys(params).forEach(function (key) {
		url += "&" + key + "=" + params[key];
	});

	var res: any = await (await fetch(url)).json();//&exintro 
	console.log("await", res.query.pages[0].extract);
	return await res.query.pages[0].extract;
}

/* if (!key) return null // 404 word not found
  const html = getProp(body, key)
  const text = cheerio.load(html).text()
    .trim() // remove extra whitespace and newlines
    .replace('English\n', '')
    .replace('Noun\n', '')
    .replace('Etymology\n', 'Etymology: ')
    .replace('Translation\n', 'Translation: ')
    .replace('Anagrams\n', 'Anagrams: ')
    .replace(/\n+/gm, '\n') // duplicate newlines
    .replace(/\n/gm, '; ')
  return {query, html, text} */