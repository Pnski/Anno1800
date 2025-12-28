import { useState } from "react";

import { invoke } from "@tauri-apps/api/core";

import { Navbar } from './layout/Navbar';
import { FileArea } from "./layout/fileView";
import { RDANode, FileItem } from "./modules/types";

export function App() {
  const [imported, setImported] = useState<FileItem[]>([]);
  const [treeData, setTreeData] = useState<RDANode[]>([]);

  const handleAddFiles = async (newFiles: FileItem[]) => {
    // 1. Update the UI list first
    setImported(prev => {
      const existingPaths = new Set(prev.map(f => f.path));
      const uniqueNewFiles = newFiles.filter(f => !existingPaths.has(f.path));
      return [...prev, ...uniqueNewFiles];
    });

    // 2. Extract all paths for the backend
    const allPaths = newFiles.map(f => f.path);

    try {
      // Invoke the backend once with the full list of paths
      // The key must match the Rust argument name "paths"
      const results = await invoke<any[]>("read_rda_files", { paths: allPaths });
      
      console.log("Scan results for all files:", results);

      // Results is an array of Results: [Ok([paths]), Err("msg"), ...]
      // You can now transform these into your treeData
    } catch (err) {
      console.error("Failed to communicate with RDA backend:", err);
    }
  };

  const handleRemove = (path: string) => {
    setImported(prev => prev.filter(f => f.path !== path));
  };

  return (
    <div className="flex flex-col h-screen overflow-hidden">
      <Navbar onFilesAdded={handleAddFiles} />
      <div className="grow overflow-y-auto px-6 py-4">
        <div className="h-full grid grid-cols-2 grid-rows-flex gap-6">
          <div className="card overflow-auto">{/* A1 */}</div>
          
          <div className="card overflow-auto row-span-3">
            <div className="card-body">
              <h2 className="card-title">Main Area</h2>
              <p className="opacity-70">Drop files and sort them on the left to begin.</p>
            </div>
          </div>
          
          {/* A2: Imported Files View */}
          <div className="card overflow-hidden flex flex-col">
            <h2 className="card-title text-sm uppercase p-4 shrink-0">Imported Files</h2>
            <div className="flex-1 min-h-0 overflow-auto px-4 pb-4">
              <FileArea 
                containerId="imported" 
                items={imported} 
                onRemove={handleRemove} 
              />
            </div>
          </div>
          
          <div className="card overflow-hidden flex flex-col">{/* A3 */}</div>
        </div>
      </div>
    </div>
  );
}