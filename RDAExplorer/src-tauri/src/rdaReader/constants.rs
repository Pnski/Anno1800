// src/rdaReader/constants.rs
use crate::rdaReader::types::VersionConfig;

pub const V20: VersionConfig = VersionConfig {
    ptr_size: 4,
    
    // Header
    magic_len: 36,
    first_block_offset: 1044,

    // Block Header 
    // V2.0: flags(4) + num(4) + comp(4) + uncomp(4) + next(4) = 20 bytes
    block_header_size: 20,

    // File Header
    file_path_len: 520,
    // 520 + 4 (offset) + 4 (comp) + 4 (uncomp) + 4 (time) + 4 (unknown)
    file_entry_size: 540, 
};

pub const V22: VersionConfig = VersionConfig {
    ptr_size: 8,

    // Header
    magic_len: 18,
    first_block_offset: 784,


    // Block Header
    // V2.2: flags(4) + num(4) + comp(8) + uncomp(8) + next(8) = 32 bytes
    block_header_size: 32,

    // File Header
    file_path_len: 520,
    // 520 + 8 (offset) + 8 (comp) + 8 (uncomp) + 8 (time) + 8 (unknown)
    file_entry_size: 560,
};

// Flags for Block Headers
pub const FLAG_COMPRESSED: u32      = 0x0001;
pub const FLAG_ENCRYPTED: u32       = 0x0010; // 0x02 in some docs, but usually 0x02 is encrypted
pub const FLAG_MEMORY_RESIDENT: u32 = 0x0100; // Often 0x04 or 0x0100
pub const FLAG_DELETED: u32         = 0x1000; // Often 0x08 or 0x1000