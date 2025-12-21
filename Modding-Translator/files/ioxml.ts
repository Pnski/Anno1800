import { writeFile, writeFileSync, readFileSync, readdirSync } from "node:fs";
import { XMLParser, XMLBuilder } from "fast-xml-parser";

const parserOptions = {
    attributeNamePrefix: "@@",
    ignoreAttributes: false,
    commentPropName: "comment",
    format: true,
    isArray: (tagName: string, jpath: string, isLeafNode :boolean) => {
        if (tagName == "ModOp") return true;
        if (tagName == "comment") return true;
        if (tagName == "Text" && isLeafNode == false) return true;
    },
    tagValueProcessor: (tagName: string, tagValue: string) => {
        if (tagName == "Text") {
            var str = tagValue.replaceAll(/\[(.*?)\](?!\))/gi, "<div class='notranslate'>$1</div>");
            return str;
        }
        return tagValue;
    }
};

export async function readXML(filePath: string): Promise<any> {
	const parser = new XMLParser(parserOptions);
	if (filePath.endsWith(".xml")) {
		const loadedXML = readFileSync(filePath, "utf-8");
		let parsedXML = await parser.parse(loadedXML);
		return await parsedXML;
	} else {
		console.error("Not a XML you donkey!");
		return false;
	}
}

const builderOptions = {
    attributeNamePrefix: "@@",
    ignoreAttributes: false,
    commentPropName: "comment",
    format: true
};

export async function writeXML(filePath: string, pXML: any): Promise<boolean> {
	const builder = new XMLBuilder(builderOptions);
	const xmlOutput = builder
		.build(pXML)
		.replaceAll("&apos;", "'")
		.replaceAll("&quot;", '"')
		.replaceAll("&lt;div class='notranslate'&gt;", "[")
		.replaceAll("&lt;/div&gt;", "]");
	writeFileSync(filePath, xmlOutput);
	return true;
}

export function readDir(filePath: string): string[] {
	return readdirSync(filePath.substring(0, filePath.lastIndexOf("\\") + 1));
}
