import * as vscode from "vscode";
const { TextServiceClient } = require("@google-ai/generativelanguage");
const { GoogleAuth } = require("google-auth-library");

const MODEL_NAME = "models/text-bison-001"; // english only, but doesn't require creditcard

var config: any = vscode.workspace.getConfiguration("amt.Google");

vscode.workspace.onDidChangeConfiguration(e => {
	if (e.affectsConfiguration("amt.Translation")) {
		config = vscode.workspace.getConfiguration("amt.Google");
	}
});

//https://cloud.google.com/vertex-ai/generative-ai/docs/model-reference/text

const promptString = "Storing teffs as feed for farm animals increases farm productivity.1 additional product is produced every second cycle";

export async function paraphrase() {
	const client = await new TextServiceClient({
		authClient: new GoogleAuth().fromAPIKey(config.Key)
	});
	await client
		.generateText({
			// required, which model to use to generate the result
			model: MODEL_NAME,
			// optional, 0.0 always uses the highest-probability result
			temperature: 0.4,
			// optional, how many candidate results to generate
			candidateCount: 2,
			// optional, number of most probable tokens to consider for generation
			top_k: 40,
			// optional, for nucleus sampling decoding strategy
			top_p: 0.95,
			// optional, maximum number of output tokens to generate
			max_output_tokens: 1024,
			prompt: {
				text: "Rewrite the following sentence and fix any grammar issues.\n\n" + promptString
			}
		})
		.then((result: any) => {
			result[0].candidates.forEach((e: any) => console.log("e", e.output));
			console.log(result);
			//console.log(JSON.stringify(result, null, 2));
			return result;
		});
}

export async function paraphrase2() {
	const client = await new TextServiceClient({
		authClient: new GoogleAuth().fromAPIKey(config.Key)
	});
	await client
		.generateText({
			// required, which model to use to generate the result
			model: MODEL_NAME,
			// optional, 0.0 always uses the highest-probability result
			temperature: 0.4,
			// optional, how many candidate results to generate
			candidateCount: 4,
			// optional, number of most probable tokens to consider for generation
			top_k: 40,
			// optional, for nucleus sampling decoding strategy
			top_p: 0.95,
			// optional, maximum number of output tokens to generate
			max_output_tokens: 1024,
			prompt: {
				text: "Give me alternative words and thesaurus for the fellowing string.\n\n" + promptString
			}
		})
		.then((result: any) => {
			//console.log(JSON.stringify(result, null, 2));
			result[0].candidates.forEach((e: any) => console.log("e", e.output));
			console.log(result);
			return result;
		});
}