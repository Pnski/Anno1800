import { Tree } from "react-arborist";
import type { NodeRendererProps } from "react-arborist";
import { Folder, FileText, ChevronDown, ChevronRight } from "lucide-react";
import { RDANode } from "../modules/types";
import { ViewWindow } from "./contentViewer";

// currently using the function from the rust backend since its slightly faster in debugmode
export function transformPathsToTree(paths: string[]): RDANode[] {
  const nodeCache: Record<string, RDANode> = {};
  const roots: RDANode[] = [];
  
  for (const path of paths) {
    const parts = path.split('/');
    let parent: RDANode | null = null;
    
    for (let i = 0; i < parts.length; i++) {
      const name = parts[i];
      const id = parts.slice(0, i + 1).join('/');
      
      // O(1) lookup with object property access
      let node = nodeCache[id];
      
      if (!node) {
        const isLeaf = i === parts.length - 1;
        node = {
          id,
          name,
          ...(isLeaf ? {} : { children: [] })
        };
        nodeCache[id] = node;
        
        // Add to tree
        if (i === 0) {
          roots.push(node);
        } else if (parent && parent.children) {
          parent.children.push(node);
        }
      }
      
      parent = node;
    }
  }
  
  return roots;
}

function Node({
  node,
  style,
  dragHandle,
}: NodeRendererProps<RDANode>) {
  return (
    <div
      style={style}
      ref={dragHandle}
      className={`flex items-center gap-2 cursor-pointer hover:bg-base-300 rounded px-2 ${
        node.isSelected ? "bg-primary text-primary-content" : ""
      }`}
      onClick={(e) => {
      if (node.isInternal) {
        node.toggle();
      } else {
        ViewWindow(node.data.name);
      }
    }}
    >
      {/* Arrow for folders */}
      <span className="w-4">
        {node.isInternal &&
          (node.isOpen ? (
            <ChevronDown size={14} />
          ) : (
            <ChevronRight size={14} />
          ))}
      </span>

      {/* Icon */}
      {node.isInternal ? (
        <Folder size={12} className="text-primary" />
      ) : (
        <FileText size={12} className="text-error" />
      )}

      <span className="text-sm truncate flex-1">{node.data.name}</span>
    </div>
  );
}

export function RdaTreeViewer({ data }: { data: RDANode[] }) {
  return (
    <Tree
      data={data}       // Add this to make it reactive to state changes
      openByDefault={false}
      width={"100%"}
      height={400}
      indent={10}
      rowHeight={16}
      overscanCount={5}
    >
      {Node}
    </Tree>
  );
}