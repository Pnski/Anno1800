export type FileItem = {
  id: ReturnType<typeof crypto.randomUUID>;
  name: string;
  path: string;
};

export interface FileAreaProps {
  containerId: "imported" | "decrypt";
  items: FileItem[];
  onRemove?: (id: string) => void;
  onItemClick?: (item: FileItem) => void;
}

export interface DropFilesProps {
  onFilesAdded: (newFiles: FileItem[]) => void;
}