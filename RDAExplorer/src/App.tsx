import "./App.css";
import { useState } from "react";

import { Navbar } from './layout/Navbar';
import { ImportFiles } from './layout/fileImporter';
import { FileArea } from "./layout/fileView";
import { FileItem } from "./modules/types";

function App() {
  const [imported, setImported] = useState<FileItem[]>([]);

  const handleAddFiles = (newFiles: FileItem[]) => {
    setImported(prev => [...prev, ...newFiles]);
  };

  return (
    <div className="flex flex-col h-screen overflow-hidden">
      <Navbar />
        <div className="flex-grow overflow-y-auto px-6 py-4">
          <div className="h-full grid grid-cols-2 grid-rows-flex gap-6">
            {/* A1: Top-left */}
            <div className="card overflow-auto">
              <ImportFiles onFilesAdded={handleAddFiles} />
            </div>
            
            {/* B1: Right column */}
            <div className="card overflow-auto row-span-3">
              <div className="card-body">
                <h2 className="card-title">Main Area</h2>
                <p className="opacity-70">Drop files and sort them on the left to begin.</p>
              </div>
            </div>
            
            {/* A2: Middle-left */}
            <div className="card overflow-hidden flex flex-col">
              <h2 className="card-title text-sm uppercase shrink-0">Imported Files</h2>
              <div className="flex-1 min-h-0 overflow-auto">
                <FileArea containerId="imported" items={imported} />
              </div>
            </div>
            
            {/* A3: Bottom-left */}
            <div className="card overflow-hidden flex flex-col ">
              <h2 className="card-title text-sm uppercase shrink-0">Decryption Queue</h2>
              <div className="flex-1 min-h-0 overflow-auto">

              </div>
            </div>
          </div>
        </div>
    </div>
  );
}

export default App;