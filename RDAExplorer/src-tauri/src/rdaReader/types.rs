use std::io::{Cursor, Read};
use byteorder::{LittleEndian, ReadBytesExt};
use serde::{Serialize, Deserialize};

#[derive(Debug, Clone, Copy, Serialize, Deserialize)]
pub struct VersionConfig {
    /// Size of the pointer (4 bytes for V2.0, 8 bytes for V2.2)
    pub ptr_size: usize,
    
    // Header Config
    pub magic_len: usize,
    pub first_block_offset: u64,

    // Block Header Config (Offsets/Sizes)
    // Note: We don't need offsets for sequential fields, just the size
    pub block_header_size: usize, 
    
    // File Header Config
    pub file_path_len: usize, // Always 520
    /// Total size of one file entry (path + metadata)
    pub file_entry_size: usize, 
}

#[derive(Debug, Clone, Copy, Serialize, Deserialize)]
pub struct BlockHeader {
    pub flags: u32,
    pub num_files: u32,
    pub directory_size: u64,      // Matches C# directorySize
    pub decompressed_size: u64,   // Matches C# decompressedSize
    pub next_block_pointer: u64,
}

impl BlockHeader {
    pub fn from_cursor(mut cursor: Cursor<Vec<u8>>, ptr_size: usize) -> Self {
        BlockHeader {
            flags: cursor.read_u32::<LittleEndian>().unwrap_or(0),
            num_files: cursor.read_u32::<LittleEndian>().unwrap_or(0),
            directory_size: Self::read_ptr(&mut cursor, ptr_size),
            decompressed_size: Self::read_ptr(&mut cursor, ptr_size),
            next_block_pointer: Self::read_ptr(&mut cursor, ptr_size),
        }
    }

    fn read_ptr(cursor: &mut Cursor<Vec<u8>>, size: usize) -> u64 {
        if size == 8 {
            cursor.read_u64::<LittleEndian>().unwrap_or(0)
        } else {
            cursor.read_u32::<LittleEndian>().unwrap_or(0) as u64
        }
    }
}