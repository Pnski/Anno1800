use tokio::fs::File;
use tokio::io::{AsyncReadExt, AsyncSeekExt, BufReader, SeekFrom};
use std::io::{Cursor, Read as StdRead};
use crate::rdaReader::types::{BlockHeader, VersionConfig};
use crate::rdaReader::constants::{V20, V22};
use flate2::read::ZlibDecoder;

pub async fn get_file_paths(
    reader: &mut BufReader<File>,
    block_offset: u64,
    block: &BlockHeader,
    config: &VersionConfig,
) -> Result<Vec<String>, String> {
    // Calculate start: Offset - directorySize
    let mut dir_start = block_offset - block.directory_size;

    if (block.flags & 4) == 4 { // Memory Resident
        dir_start -= (config.ptr_size * 2) as u64;
    }

    reader.seek(SeekFrom::Start(dir_start)).await.map_err(|e| e.to_string())?;
    let mut buffer = vec![0u8; block.directory_size as usize];
    reader.read_exact(&mut buffer).await.map_err(|e| e.to_string())?;

    let is_compressed = (block.flags & 1) == 1;
    let final_buffer = if is_compressed {
        let mut decoder = ZlibDecoder::new(&buffer[..]);
        let mut decompressed = Vec::with_capacity(block.decompressed_size as usize);
        decoder.read_to_end(&mut decompressed).map_err(|e| e.to_string())?;
        decompressed
    } else {
        buffer
    };

    let mut cursor = Cursor::new(final_buffer);
    let mut file_paths = Vec::new();

    for _ in 0..block.num_files {
        let mut name_buf = vec![0u8; config.file_path_len];
        StdRead::read_exact(&mut cursor, &mut name_buf).map_err(|e| e.to_string())?;

        let file_name = String::from_utf16_lossy(
            &name_buf.chunks_exact(2)
                .map(|chunk| u16::from_le_bytes([chunk[0], chunk[1]]))
                .take_while(|&u| u != 0)
                .collect::<Vec<u16>>()
        ).replace('\\', "/");

        let metadata_to_skip = (config.ptr_size * 5) as u64; 
        cursor.set_position(cursor.position() + metadata_to_skip);
        file_paths.push(file_name);
    }
    Ok(file_paths)
}

pub async fn read_structure(file_path: String) -> Result<Vec<String>, String> {
    let file = File::open(&file_path).await.map_err(|e| e.to_string())?;
    let file_size = file.metadata().await.map_err(|e| e.to_string())?.len();
    let mut reader = BufReader::new(file);

    let mut magic = [0u8; 2];
    reader.read_exact(&mut magic).await.map_err(|e| e.to_string())?;
    
    let config = match (magic[0], magic[1]) {
        (b'R', 0) => V20,
        (b'R', b'e') => V22,
        _ => return Err(format!("Invalid RDA: {}", file_path)),
    };

    let mut all_paths = Vec::new();
    let mut current_block_offset = config.first_block_offset;

    while current_block_offset != 0 && current_block_offset < file_size {
        let mut header_buf = vec![0u8; config.block_header_size];
        reader.seek(SeekFrom::Start(current_block_offset)).await.map_err(|e| e.to_string())?;
        reader.read_exact(&mut header_buf).await.map_err(|e| e.to_string())?;
        
        let block_info = BlockHeader::from_cursor(Cursor::new(header_buf), config.ptr_size);

        if (block_info.flags & 8) != 8 { // Skip deleted
            if let Ok(mut paths) = get_file_paths(&mut reader, current_block_offset, &block_info, &config).await {
                all_paths.append(&mut paths);
            }
        }
        current_block_offset = block_info.next_block_pointer;
    }
    Ok(all_paths)
}