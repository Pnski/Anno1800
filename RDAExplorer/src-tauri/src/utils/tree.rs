// tree.rs
use serde::Serialize;

#[derive(Debug, Serialize, Clone)]
pub struct FileTreeNode {
    pub id: String,
    pub name: String,
    pub children: Option<Vec<FileTreeNode>>,
}

pub fn build_tree(paths: &[String]) -> Vec<FileTreeNode> {
    if paths.is_empty() {
        return Vec::new();
    }

    // 1. Sort indices for O(1) "last child" check
    let mut indices: Vec<usize> = (0..paths.len()).collect();
    indices.sort_unstable_by(|&a, &b| paths[a].cmp(&paths[b]));

    let mut roots: Vec<FileTreeNode> = Vec::new();

    for idx in indices {
        let path = &paths[idx];
        let parts: Vec<&str> = path.split('/').collect();
        let last_part_idx = parts.len() - 1;
        
        let mut current_level = &mut roots;
        let mut current_id = String::with_capacity(path.len());

        for (i, part) in parts.iter().enumerate() {
            if i > 0 { current_id.push('/'); }
            current_id.push_str(part);

            let is_file = i == last_part_idx;

            // Since paths are sorted, if this segment exists, 
            // it MUST be the last element of the current vector.
            let exists = current_level.last().map_or(false, |last| last.name == *part);

            if exists {
                // If it exists and it's not the file, we move into its children.
                if !is_file {
                    // We can safely unwrap here because by definition 
                    // a non-file path segment must have children.
                    current_level = current_level.last_mut().unwrap().children.as_mut().unwrap();
                }
            } else {
                // Create the node. 
                // Folders (not is_file) get Some(Vec), Files get None.
                let new_node = FileTreeNode {
                    id: current_id.clone(),
                    name: part.to_string(),
                    children: if is_file { None } else { Some(Vec::with_capacity(8)) },
                };
                
                current_level.push(new_node);

                // Move current_level pointer to the newly created children vector
                if !is_file {
                    current_level = current_level.last_mut().unwrap().children.as_mut().unwrap();
                }
            }
        }
    }
    roots
}