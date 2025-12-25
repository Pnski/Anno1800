import "./App.css";
import { useState } from "react";

import Navbar from './layout/Navbar';
import DropFolder, { FileItem } from './layout/fileImporter';
import DragFileArea from "./modules/dragable";

function App() {
  const [files, setFiles] = useState<FileItem[]>([]);

  const handleAddFiles = (newFiles: FileItem[]) => {
    setFiles(prev => [...prev, ...newFiles]);
  };

  return (
  <div className="flex flex-col h-screen overflow-hidden">
    <Navbar />
    
    {/* Fixed height container based on viewport minus navbar */}
    <div className="flex-grow overflow-y-auto px-6 py-4">
      <div className="h-full grid grid-cols-2 grid-rows-flex gap-6">
        {/* A1: Top-left (20% height) */}
        <div className="card overflow-auto">
          <DropFolder onFilesAdded={handleAddFiles} />
        </div>
        
        {/* B1: Right column (100% height, spans all rows) */}
        <div className="card overflow-auto row-span-3">
          <div className="card-body">
            <h2 className="card-title">Main Area</h2>
            <p className="opacity-70">Drop files and sort them on the left to begin.</p>
          </div>
        </div>
        
        {/* A2: Middle-left (40% height) */}
        <div className="card overflow-hidden flex flex-col">
          <h2 className="card-title text-sm uppercase shrink-0">File Queue 1</h2>
          <div className="flex-1 min-h-0 overflow-auto">
            <DragFileArea items={files} setItems={setFiles} />
          </div>
        </div>
        
        {/* A3: Bottom-left (40% height) */}
        <div className="card overflow-hidden flex flex-col ">
          <h2 className="card-title text-sm uppercase shrink-0">File Queue 2</h2>
          <div className="flex-1 min-h-0 overflow-auto">
            <DragFileArea items={files} setItems={setFiles} />
          </div>
        </div>
      </div>
    </div>
  </div>
  );
}

export default App;