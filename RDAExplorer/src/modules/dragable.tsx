import { X, FileCode, GripVertical } from "lucide-react";
import {
  DndContext,
  closestCenter,
  KeyboardSensor,
  PointerSensor,
  useSensor,
  useSensors,
  DragEndEvent,
} from "@dnd-kit/core";
import {
  arrayMove,
  SortableContext,
  sortableKeyboardCoordinates,
  verticalListSortingStrategy,
  useSortable,
} from "@dnd-kit/sortable";
import { CSS } from "@dnd-kit/utilities";

// --- Sub-component for individual file items ---
function FileRow({ id, name, onRemove }: { id: string; name: string; onRemove: (id: string) => void }) {
  const { attributes, listeners, setNodeRef, transform, transition } = useSortable({ id });

  const style = {
    transform: CSS.Transform.toString(transform),
    transition,
  };

  return (
    <div
      ref={setNodeRef}
      style={style}
      className="flex items-center gap-3 p-3 mb-2 bg-base-200 border border-base-300 rounded-lg group hover:border-primary transition-colors"
    >
      <div {...attributes} {...listeners} className="cursor-grab active:cursor-grabbing text-base-content/30 hover:text-primary">
        <GripVertical size={18} />
      </div>
      <FileCode className="text-primary" size={20} />
      <span className="flex-1 truncate text-sm font-medium">{name}</span>
      <button 
        onClick={() => onRemove(id)}
        className="btn btn-ghost btn-xs btn-circle text-error opacity-0 group-hover:opacity-100 transition-opacity"
      >
        <X size={16} />
      </button>
    </div>
  );
}

interface DragFileAreaProps {
  items: { id: string; name: string }[];
  setItems: React.Dispatch<React.SetStateAction<{ id: string; name: string }[]>>;
}

export function DragFileArea({ items, setItems }: DragFileAreaProps) {
  const sensors = useSensors(
    useSensor(PointerSensor),
    useSensor(KeyboardSensor, { coordinateGetter: sortableKeyboardCoordinates })
  );

  const removeFile = (id: string) => setItems(prev => prev.filter(f => f.id !== id));

  const handleDragEnd = (event: DragEndEvent) => {
    const { active, over } = event;
    if (over && active.id !== over.id) {
      setItems((prev) => {
        const oldIndex = prev.findIndex((i) => i.id === active.id);
        const newIndex = prev.findIndex((i) => i.id === over.id);
        return arrayMove(prev, oldIndex, newIndex);
      });
    }
  };

  return ( // Added the missing 'return' statement here!
    <div className="flex-1 overflow-y-auto rounded-xl border border-base-200 p-2 shadow-inner min-h-[200px]">
      <DndContext sensors={sensors} collisionDetection={closestCenter} onDragEnd={handleDragEnd}>
        <SortableContext items={items.map(f => f.id)} strategy={verticalListSortingStrategy}>
          {items.map((file) => (
            <FileRow key={file.id} id={file.id} name={file.name} onRemove={removeFile} />
          ))}
        </SortableContext>
      </DndContext>
    </div>
  );
}

export default DragFileArea;