use tokio::fs::File;
use tokio::io::AsyncReadExt;

pub async fn read_var_ptr(file: &mut File, size: u8) -> Result<u64, String> {
    if size == 8 {
        read_u64_le(file).await
    } else {
        Ok(read_u32_le(file).await? as u64)
    }
}

pub async fn read_bytes(file: &mut File, count: usize) -> Result<Vec<u8>, String> {
    let mut buf = vec![0u8; count]; // Vec is Sized and allocated on the heap
    file.read_exact(&mut buf)
        .await
        .map_err(|e| e.to_string())?;
    
    Ok(buf) // We return the ownership of the Vec
}

pub async fn read_u32_le(file: &mut File) -> Result<u32, String> {
    let mut buf = [0u8; 4];
    file.read_exact(&mut buf).await.map_err(|e| e.to_string())?;
    Ok(u32::from_le_bytes(buf))
}

pub async fn read_u64_le(file: &mut File) -> Result<u64, String> {
    let mut buf = [0u8; 8];
    file.read_exact(&mut buf).await.map_err(|e| e.to_string())?;
    Ok(u64::from_le_bytes(buf))
}