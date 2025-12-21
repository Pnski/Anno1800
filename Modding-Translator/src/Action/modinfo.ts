import * as vscode from "vscode";
import { readFileSync, writeFile } from "fs";
import { singleTranslate } from "../../lang/scripts/handleProvider";
import aLn from "../../lang/config/AnnoLanguages";

function readJson(filePath: string): any {
	if (filePath.endsWith(".json")) {
		const loadedJSON = readFileSync(filePath, "utf-8");
		return JSON.parse(loadedJSON);
	} else {
		console.error("Not a JSON you donkey!");
		return {};
	}
}

function writeJSON(filePath: string, pJson: any) {
	const data = new Uint8Array(Buffer.from(JSON.stringify(pJson, null, "\t")));
	writeFile(filePath, data, err => {
		if (err) throw err;
		vscode.window.showInformationMessage("File has been saved!");
	});
}

export async function ModInfo(filePath: string): Promise<any> {
	const pJson = await readJson(filePath);
	const modinfoCategory: string[] = ["Category", "ModName", "Description", "KnownIssues"];
	//console.log(pJson, modinfoCategory);
	// .Category .ModName .Description
	await vscode.window.withProgress(
		{
			location: vscode.ProgressLocation.Notification,
			title: "Translation in progress",
			cancellable: false
		},
		async (progress, token) => {
			var i: number = 0;
			progress.report({
				message: `${Math.trunc((i / 4) * 100)}%`,
				increment: 0
			});
			for (let jsonCat of modinfoCategory) {
				try {
					for (const [key, value] of Object.entries(pJson[jsonCat])) {
						if (value !== null) {
							pJson[jsonCat][key] = await singleTranslate(value as string, aLn[key.toLowerCase()]);
						}
					}
				} catch {console.log("Category '"+jsonCat+"' not found, continue.")}
				i++;
				progress.report({
					message: `${Math.trunc((i / 4) * 100)}%`,
					increment: 100 / 4
				});
			}
		}
	);
	writeJSON(filePath, pJson);
	vscode.window.showInformationMessage("modinfo.json translated, check new values manually");
}
