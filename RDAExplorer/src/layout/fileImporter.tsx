import { useState } from "react";
import { open } from "@tauri-apps/plugin-dialog";

// Define the type for better reusability
export interface FileItem {
  id: string;
  name: string;
}

interface DropFilesProps {
  onFilesAdded: (newFiles: FileItem[]) => void;
}

export default function importFiles({ onFilesAdded }: DropFilesProps) {
  const [isDraggingOver, setIsDraggingOver] = useState(false);

  const handleFileFiltering = (fileList: File[] | string[]) => {
    const validFiles: FileItem[] = [];

    fileList.forEach((file) => {
      const name = typeof file === "string" ? file : file.name;
      if (name.toLowerCase().endsWith(".rda")) {
        validFiles.push({ id: `${name}-${Date.now()}-${Math.random()}`, name });
      }
    });

    onFilesAdded(validFiles);
  };

  function onDrop(e: React.DragEvent<HTMLDivElement>) {
    e.preventDefault();
    setIsDraggingOver(false);
    handleFileFiltering(Array.from(e.dataTransfer.files));
  }

  async function openFolderDialogue() {
    try {
      const selected = await open({ directory: false, multiple: true, title: "Select Files2", filters: [{ name: 'test', extensions: [".rda"] }] });
      if (selected && typeof selected === "string") {
        // In a real Tauri app, you might use @tauri-apps/api/fs to list files in this dir
        // For now, we use the folder name as an entry
        handleFileFiltering([selected]);
      }
    } catch (error) {
      console.error(error);
    }
  }


  return (
    <div className="flex flex-col gap-4">
      {/* Drop Zone / Header */}
      <div
        onDragOver={(e) => { e.preventDefault(); setIsDraggingOver(true); }}
        onDragLeave={() => setIsDraggingOver(false)}
        onDrop={onDrop}
        onClick={openFolderDialogue}
        className={`
          relative border-2 border-dashed rounded-xl p-2 cursor-pointer
          flex flex-col items-center justify-center gap-2 py-4 
          ${isDraggingOver ? "border-primary bg-primary/5" : "border-base-300 hover:border-primary/50"}
        `}
      >
        <div className="text-center">
          <p className="font-bold">Click or Drag .rda files here</p>
        </div>
      </div>
    </div>
  );
}