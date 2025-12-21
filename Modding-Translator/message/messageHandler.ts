import { window } from "vscode";

export function visualError(Message: string): void {
	console.error("Caught error in machinetranslation of " + Message + " due to unknown reason (internet related).");
	window.showErrorMessage("Caught error with translation of: " + Message);
}

export function visualWarn(Message: string): void {
	window.showWarningMessage("Caught error with translation of: " + Message);
}

export function visualMessage(Message: string): void {
	window.showInformationMessage(Message);
}