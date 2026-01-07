#[derive(Debug)]
pub enum VERSION {
    V0,
    V2
}

impl VERSION {
    pub fn ptr_size(&self) -> usize {
        match self {
            VERSION::V0 => 4,
            VERSION::V2 => 8,
        }
    }
    pub fn header_magic(&self) -> usize {
        match self {
            VERSION::V0 => 36,
            VERSION::V2 => 18,
        }
    }
    pub fn header_block(&self) -> usize {
        match self {
            VERSION::V0 => 1044,
            VERSION::V2 => 784,
        }
    }
    pub fn file_block(&self) -> usize {
        match self {
            VERSION::V0 => 20,
            VERSION::V2 => 40,
        }
    }
}

pub const FLAG_NULL: u32            = 0x0000;
pub const FLAG_COMPRESSED: u32      = 0x0001;
pub const FLAG_ENCRYPTED: u32       = 0x0010;
pub const FLAG_MEMORY_RESIDENT: u32 = 0x0100;
pub const FLAG_DELETED: u32         = 0x1000;