use memmap2::Mmap;

use crate::rdaReader::constants::{VERSION};

#[derive(Debug)]
pub struct FILEREADER {
    pub mmap: Mmap,
    pub version: VERSION,
    pub cur_ptr : usize,
}

#[derive(Debug)]
pub struct BlockHeader {
    pub cur_ptr: usize,
    pub flags: u32,
    pub num_files: u32,
    pub directory_size: u64,      // Matches C# directorySize
    pub decompressed_size: u64,   // Matches C# decompressedSize
    pub next_block_pointer: u64,
}