import { useState } from "react";

import { invoke } from "@tauri-apps/api/core";

import { Navbar } from './layout/Navbar';
import { FileArea } from "./layout/fileView";
import { RdaTreeViewer, transformPathsToTree } from "./layout/treeView";
import { RDANode, FileItem } from "./modules/types";

export function App() {
  const [imported, setImported] = useState<FileItem[]>([]);
  const [treeData, setTreeData] = useState<RDANode[]>([]);

  const handleAddFiles = async (newFiles: FileItem[]) => {
    // Compute the new state first
    const newImported = [...imported];
    const existingPaths = new Set(imported.map(f => f.path));
    
    const uniqueNewFiles = newFiles.filter(f => !existingPaths.has(f.path));
    newImported.push(...uniqueNewFiles);
    
    // Now update state AND use the computed value
    setImported(newImported);
    
    // Extract all paths from the computed value
    const allPaths = newImported.map(f => f.path);
    
    try {
      console.log("ALL paths:", allPaths);
      console.time();
      const nestedData = await invoke<RDANode[]>("read_rda_files", { paths: allPaths });
      /* const results = await invoke<string[]>("read_rda_files", { paths: allPaths });
      
      const nestedData = transformPathsToTree(results); */
      console.timeEnd();
      setTreeData(nestedData);

    } catch (err) {
      console.error("Failed to communicate with RDA backend:", err);
    }
  };

  const handleRemove = async (path: string) => {
    setImported(prev => prev.filter(f => f.path !== path));
    const allPaths = imported.map(f => f.path);

    try {
      const results = await invoke<RDANode[]>("read_rda_files", { paths: allPaths });
      //const results = await invoke<string[]>("read_rda_files", { paths: allPaths });
      //const nestedData = await invoke<RDANode[]>('get_file_tree', { paths: results });
      setTreeData(results);
    } catch (err) {
      console.error("Failed to communicate with RDA backend:", err);
    }
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
              <RdaTreeViewer data={treeData} />
            </div>
          </div>
          
          {/* A2: Imported Files View */}
          <div className="card overflow-hidden flex flex-col">
            <h2 className="card-title text-sm uppercase p-4 shrink-0">Imported Files</h2>
            <div className="flex-1 overflow-auto px-4 pb-4">
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