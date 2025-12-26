// src-tauri/src/lib.rs or main.rs
#[tauri::command]
fn process_rda_file(path: String) -> Result<String, String> {
    println!("Processing file at: {}", path);
    // Use std::fs::read or a specific RDA parser library here
    // let data = std::fs::read(path).map_err(|e| e.to_string())?;
    
    Ok(format!("Successfully read {}", path))
}

#[cfg_attr(mobile, tauri::mobile_entry_point)]
pub fn run() {
    tauri::Builder::default()
        .plugin(tauri_plugin_dialog::init())
        .plugin(tauri_plugin_process::init())
        .invoke_handler(tauri::generate_handler![process_rda_file]) // Register it
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}