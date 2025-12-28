import { Tree } from "react-arborist";
import { Folder, FileText, ChevronDown, ChevronRight } from "lucide-react";
import { RDANode } from "../modules/types";

export function RdaTreeViewer({ data }: { data: RDANode[] }) {
  return (
    <Tree
      initialData={data}
      openByDefault={false}
      width={"100%"}
      height={600} // This should match your card height
      indent={20}
      rowHeight={32}
      overScanCount={5}
    >
      {({ node, style, dragHandle }) => (
        <div
          style={style}
          ref={dragHandle}
          className={`flex items-center gap-2 cursor-pointer hover:bg-base-300 rounded px-2 ${
            node.isSelected ? "bg-primary text-primary-content" : ""
          }`}
          onClick={() => node.toggle()}
        >
          {/* Arrow for folders */}
          <span className="w-4">
            {node.isInternal && (
              node.isOpen ? <ChevronDown size={14} /> : <ChevronRight size={14} />
            )}
          </span>

          {/* Icons based on type */}
          {node.isInternal ? (
            <Folder size={16} className="text-warning" />
          ) : (
            <FileText size={16} className="text-info" />
          )}

          <span className="text-sm truncate">{node.data.name}</span>
        </div>
      )}
    </Tree>
  );
}