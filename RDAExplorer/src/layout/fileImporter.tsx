import { useState } from "react";
import { open } from "@tauri-apps/plugin-dialog";
import { FileItem } from "../modules/types";

export function ImportFiles({ onFilesAdded }: DropFilesProps) {
  const [isDraggingOver, setIsDraggingOver] = useState(false);

  const handleFileFiltering = (fileList: DroppedFile[]) => {
    const validFiles: FileItem[] = fileList
      .map((file) => {
        const path =
          typeof file === "string"
            ? file
            : file.path; // ✅ now typed correctly

        const name =
          typeof file === "string"
            ? file.split(/[/\\]/).pop()!
            : file.name;

        if (!name.toLowerCase().endsWith(".rda")) return null;

        return {
          id: crypto.randomUUID(),
          name,
          path,
        };
      })
      .filter((f): f is FileItem => f !== null);
      console.warn(validFiles)
    onFilesAdded(validFiles);
  };


  function onDrop(e: React.DragEvent<HTMLDivElement>) {
    e.preventDefault();
    setIsDraggingOver(false);
    handleFileFiltering(Array.from(e.dataTransfer.files));
  }

  async function openFilesDialogue() {
    try {
      const selected = await open({
        multiple: true,
        directory: false,
        title: "Select Files",
        filters: [{ name: "RDA files", extensions: ["rda"] }],
      });

      if (Array.isArray(selected)) {
        handleFileFiltering(selected);
      }
    } catch (error) {
      console.error(error);
    }
  }

  return (
    <div className="flex flex-col gap-4">
      <div
        onDragOver={(e) => {
          e.preventDefault();
          setIsDraggingOver(true);
        }}
        onDragLeave={() => setIsDraggingOver(false)}
        onDrop={onDrop}
        onClick={openFilesDialogue}
        className={`
          relative border-2 border-dashed rounded-xl p-2 cursor-pointer
          flex flex-col items-center justify-center gap-2 py-4 
          ${
            isDraggingOver
              ? "border-primary bg-primary/5"
              : "border-base-300 hover:border-primary/50"
          }
        `}
      >
        <p className="font-bold">Click or Drag .rda files here</p>
      </div>
    </div>
  );
}
