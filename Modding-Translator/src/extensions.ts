import * as vscode from "vscode";

import * as HoverProvider from "../lang/HoverProvider";

interface CommandHandlers {
	[key: string]: (...args: any[]) => any;
}

// Import Commands and assert its type
const Commands: CommandHandlers = require("./Action/index");

interface CommandContribution {
	command: string;
	title: string;
}

export function activate(context: vscode.ExtensionContext): any {
	const { commands } = vscode.extensions.getExtension("pnski.amt").packageJSON.contributes;
	commands.forEach(({ command, title }: CommandContribution) => {
		// Use plain JavaScript to get the last element of the split command
		const commandName = command.split(".").pop() as string;
		const handler = Commands[commandName];
		const disposable = vscode.commands.registerCommand(command, args => handler(args));
		context.subscriptions.push(disposable);
	});

	//vscode.languages.registerHoverProvider(HoverProvider.Lan, HoverProvider.Provider);
}

export function deactivate() {}
