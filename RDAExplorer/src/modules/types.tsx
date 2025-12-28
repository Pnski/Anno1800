export type FileItem = {
  path: string;
  name: string;
};

export interface FileAreaProps {
  containerId: "imported" | "decrypt";
  items: FileItem[];
  onRemove?: (id: string) => void;
  onItemClick?: (item: FileItem) => void;
}

export interface HandleFilesProps {
  handleAddFiles: (newFiles: FileItem[]) => void;
}

export interface RDANode {
  id: string;      // Internal path or unique hash
  name: string;    // Filename
  children?: RDANode[]; // Only present if it's a folder
  isOpen?: boolean;
}