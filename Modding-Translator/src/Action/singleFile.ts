import * as vscode from "vscode";
import { readXML, writeXML } from "../../files/ioxml";
import { getCurrentShorts, getMissingShorts } from "../../lang/scripts/handleProvider";
import aLn from "../../lang/config/AnnoLanguages";

import { TextsTranslation } from "../../Component/modOp";

export async function _singleFile(filePath: string): Promise<void> {
	let _get: any;
	const loca = filePath.match("texts_(.*).xml")[1]; // current language
	if (typeof loca !== "string") {
		console.error("donkey");
		return;
	}
	const pXML = await readXML(filePath);

	let config = vscode.workspace.getConfiguration("anno-modding-translator.defaultComment");
	await vscode.window.withProgress(
		{
			location: vscode.ProgressLocation.Notification,
			title: "Translation in progress...",
			cancellable: false
		},
		async (progress, token) => {
			if (config.enable) {
				_get = await TextsTranslation(pXML, [aLn[loca.toLowerCase()]]);
			} else {
				_get = await TextsTranslation(pXML, [aLn[loca.toLowerCase()]]);
			}
		}
	);
	vscode.window.showWarningMessage("Translation complete, attempting to write file.");
	writeXML(filePath, _get[aLn[loca]]);
}
