import * as vscode from "vscode";

import { singleTranslate } from "./scripts/handleProvider";
import { wiktionaryLookup } from "./scripts/wiktionary/wiktionaryProvider";

var config: any = vscode.workspace.getConfiguration("amt.Translation");

vscode.workspace.onDidChangeConfiguration(e => {
	if (e.affectsConfiguration("amt.Translation")) {
		config = vscode.workspace.getConfiguration("amt.Translation");
	}
});

export const Lan = "*";

//https://aistudio.google.com/app/apikey

export const Provider: vscode.HoverProvider = {
	async provideHover(document, position, token) {
		let word = document.getText(document.getWordRangeAtPosition(position));
		let hover = await singleTranslate(word, config.Lang);
		let wiki = await wiktionaryLookup(hover, config.Lang);
		return new vscode.Hover(hover + "🔹  \n" + wiki + "  \n🔹");
	}
};
