#![cfg_attr(not(debug_assertions), windows_subsystem = "windows")]

mod rdaReader;
mod utils;

#[tauri::command]
async fn read_rda_files(
    paths: Vec<String>
) -> //Result<Vec<String>, String>
Result<Vec<utils::FileTreeNode>, String> {
    let mut tasks = Vec::new();

    for path in paths {
        tasks.push(tokio::spawn(async move {
            let mut reader = rdaReader::FILEREADER::initialize(&path)?;
            reader.read_files_from_block()
        }));
    }

    let mut all_results = Vec::new();

    for task in tasks {
        match task.await {
            Ok(Ok(files)) => all_results.extend(files),
            Ok(Err(e)) => return Err(e),
            Err(e) => return Err(format!("Task panic: {}", e)),
        }
    }
    //println!("main task wants to return: {:?}", all_results);
    let tree = utils::build_tree(&all_results);
    Ok(tree)
    //Ok(all_results)
}

#[tauri::command]
async fn get_file_tree(paths: Vec<String>) -> Result<Vec<utils::FileTreeNode>, String> {
    let tree = utils::build_tree(&paths);
    Ok(tree)
}

fn main() {
    tauri::Builder::default()
        .plugin(tauri_plugin_dialog::init())
        .plugin(tauri_plugin_process::init())
        .plugin(tauri_plugin_fs::init())
        .invoke_handler(tauri::generate_handler![
            read_rda_files,
            get_file_tree
        ])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}