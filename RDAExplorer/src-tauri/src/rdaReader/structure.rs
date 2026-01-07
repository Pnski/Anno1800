use memmap2::Mmap;
use tokio::task;

use crate::rdaReader::{
    types::{
        FILEREADER,
        BlockHeader,
    },
    constants::{VERSION},
};

impl FILEREADER {
    fn get_bytes(&self, position: usize, length: usize) -> Result<&[u8], String> {
        if position + length > self.mmap.len() {
            return Err("Out of Bounds, aborting".to_string());
        }
        Ok(&self.mmap[position .. position+length])
    }

    fn get_u64(&self, position: usize, size: usize) -> Result<u64, String> {
        let bytes = self.get_bytes(position, size)?;
        match size {
            4 => Ok(u32::from_le_bytes(bytes.try_into().unwrap()) as u64),
            8 => Ok(u64::from_le_bytes(bytes.try_into().unwrap())),
            _ => Err(format!("Unsupported pointer size: {}", size)),
        }
    }

    pub fn initialize(file_path: &str) -> Result<Self, String> {
        let file = std::fs::File::open(file_path).map_err(|e| e.to_string())?;
        let mmap = unsafe { Mmap::map(&file).map_err(|e| e.to_string())? };
        let version = match (mmap[0], mmap[1]) {
            (b'R', 0) => VERSION::V0,
            (b'R', b'e') => VERSION::V2,
            _ => return Err(format!("Invalid RDA: {}", file_path)),
        };
        let bytes = &mmap[version.header_block() .. version.header_block() + version.ptr_size()];
        let cur_ptr = match version.ptr_size() {
            4 => u32::from_le_bytes(bytes.try_into().unwrap()) as usize,
            8 => u64::from_le_bytes(bytes.try_into().unwrap()) as usize,
            _ => return Err("Unsupported pointer size".to_string()),
        };
        Ok(FILEREADER {
            mmap,
            version,
            cur_ptr
        })
    }

    fn read_block(&mut self) -> Result<BlockHeader, String> {
        let cur_ptr : usize = self.cur_ptr;
        let flags : u32 = u32::from_le_bytes(self.mmap[self.cur_ptr..self.cur_ptr+4].try_into().unwrap());
        let num_files : u32 = u32::from_le_bytes(self.mmap[self.cur_ptr+4..self.cur_ptr+8].try_into().unwrap());
        let dir_size : u64 = self.get_u64(self.cur_ptr+8,self.version.ptr_size())?;
        let decomp_size : u64 = self.get_u64(self.cur_ptr+8+self.version.ptr_size(),self.version.ptr_size())?;
        let next_block_pointer : u64 = self.get_u64(self.cur_ptr+8+self.version.ptr_size()*2,self.version.ptr_size())?;
        self.cur_ptr = next_block_pointer as usize;
        Ok(BlockHeader{
            cur_ptr,
            flags,
            num_files,
            directory_size: dir_size,
            decompressed_size: decomp_size,
            next_block_pointer
        })
    }

    fn read_file_names(&self, block:BlockHeader) -> Result<Vec<String>, String> {
        let mut files = Vec::new();
        let mut current = block.cur_ptr - block.num_files as usize * (520+self.version.file_block());
        for i in 0..block.num_files {
            let bytes = self.get_bytes(current, 520)?;

            let u16s: Vec<u16> = bytes
                .chunks_exact(2)
                .map(|c| u16::from_le_bytes([c[0], c[1]]))
                .take_while(|&c| c != 0)
                .collect();

            let name = String::from_utf16_lossy(&u16s);
            files.push(name);
            current += 520 + self.version.file_block();
        }
        Ok(files)
    }


    pub fn read_files_from_block(&mut self) -> Result<Vec<String>, String> {
        let mut files = Vec::new();

        while self.cur_ptr < self.mmap.len() {
            //println!("{:?}", &self);
            let cur_block : BlockHeader = self.read_block()?;
            files.extend(self.read_file_names(cur_block)?);
        }
        //println!("{:?}",files);
        Ok(files)
    }
}