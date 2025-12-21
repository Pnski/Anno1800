import * as vscode from "vscode";
import { ModInfo } from "./modinfo";
import { _singleFile } from "./singleFile";
import { _multiFile } from "./multiFile";

async function testingStuff(_uri: vscode.Uri) {
	console.log("testingStuff");
	console.log("uri", _uri.fsPath);
}

async function modInfo(uri: vscode.Uri) {
	const jsonPath = (uri ?? vscode.window.activeTextEditor.document.uri).fsPath;
	await ModInfo(jsonPath);
}

async function singleFile(uri: vscode.Uri) {
	const xmlPath = (uri ?? vscode.window.activeTextEditor.document.uri).fsPath;
	await _singleFile(xmlPath);
}

async function multiFile(uri: vscode.Uri) {
	const xmlPath = (uri ?? vscode.window.activeTextEditor.document.uri).fsPath;
	await _multiFile(xmlPath);
}

async function Inplace() {
	const mSel = vscode.window.activeTextEditor.selection;
	if (mSel) {
		console.log(vscode.window.activeTextEditor.document.getText(mSel));
	} else {
		vscode.window.showErrorMessage("Nothing selected to translate!");
	}
}

export { testingStuff, singleFile, multiFile, modInfo, Inplace };
