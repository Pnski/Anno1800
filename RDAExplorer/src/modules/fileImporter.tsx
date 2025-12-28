import { open } from "@tauri-apps/plugin-dialog";
import { readDir } from "@tauri-apps/plugin-fs"; // Add this
import { FileItem } from "./types";

export async function openFilesDialogue(onFilesAdded: (files: FileItem[]) => void) {
  const selected = await open({
    multiple: true,
    filters: [{ name: "RDA files", extensions: ["rda"] }],
  });

  if (Array.isArray(selected)) {
    const newFiles = selected.map(path => ({
      path: path,
      name: path.split(/[/\\]/).pop() || path
    }));
    onFilesAdded(newFiles);
  }
}

export async function openFolderDialogue(onFilesAdded: (files: FileItem[]) => void) {
  const selected = await open({
    directory: true,
    multiple: false,
  });

  if (selected && typeof selected === 'string') {
    const entries = await readDir(selected);
    const rdaFiles: FileItem[] = entries
      .filter(e => e.name?.toLowerCase().endsWith('.rda'))
      .map(e => ({
        path: `${selected}\\${e.name}`,
        name: e.name || ""
      }));
    onFilesAdded(rdaFiles);
  }
}