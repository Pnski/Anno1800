import { X, FileCode } from "lucide-react";
import { FileAreaProps } from "../modules/types";

// --- Single file row (NO drag logic) ---
function FileRow({
  id,
  name,
  onRemove,
  onClick,
}: {
  id: string;
  name: string;
  onRemove?: (id: string) => void;
  onClick?: () => void;
}) {
  return (
    <div
      onDoubleClick={onClick}
      className="flex items-center gap-3 p-3 mb-2 bg-base-200 border border-base-300 rounded-lg group hover:border-primary transition-colors"
    >
      <FileCode className="text-primary" size={18} />

      <span className="flex-1 truncate text-sm font-medium">
        {name}
      </span>

      {onRemove && (
        <button
          onClick={() => onRemove(id)}
          className="btn btn-ghost btn-xs btn-circle text-error opacity-0 group-hover:opacity-100 transition-opacity"
        >
          <X size={14} />
        </button>
      )}
    </div>
  );
}

export function FileArea({
  containerId,
  items,
  onRemove,
  onItemClick,
}: FileAreaProps) {
  const sortedItems = [...items].sort((a, b) =>
    a.name.localeCompare(b.name)
  );

  return (
    <div
      className="flex-1 min-h-[200px] rounded-xl border border-base-200 p-2 shadow-inner bg-base-100/50"
      data-container={containerId}
    >
      {sortedItems.map(file => (
        <FileRow
          key={file.path}
          id={file.path}
          name={file.name}
          onRemove={onRemove}
          onClick={() => onItemClick?.(file)}
        />
      ))}

      {sortedItems.length === 0 && (
        <div className="h-full w-full flex items-center justify-center opacity-30">
          <p className="text-xs">No files</p>
        </div>
      )}
    </div>
  );
}