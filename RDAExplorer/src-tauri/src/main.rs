#![cfg_attr(not(debug_assertions), windows_subsystem = "windows")]

mod rdaReader;

#[tauri::command]
async fn read_rda_files(paths: Vec<String>) -> Vec<Result<Vec<String>, String>> {
    let mut tasks = Vec::new();

    for path in paths {
        tasks.push(tokio::spawn(async move {
            rdaReader::read_structure(path).await
        }));
    }

    let results = futures::future::join_all(tasks).await;
    
    results.into_iter()
        .map(|r| match r {
            Ok(inner) => inner,
            Err(e) => Err(format!("Thread panic: {}", e)),
        })
        .collect()
}

fn main() {
    tauri::Builder::default()
        .plugin(tauri_plugin_dialog::init())
        .plugin(tauri_plugin_process::init())
        .plugin(tauri_plugin_fs::init())
        .invoke_handler(tauri::generate_handler![read_rda_files])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}