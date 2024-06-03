using System;

public class GPUBuffer
{
    public Int64 GPUBufferNameOffset { get; set; }
    public string GPUBufferName { get; set; }
    public uint GPBFNameUTF16Hash { get; set; }
    public uint GPBFNameASCIIHash { get; set; }
    public int NameOffsetIndex { get; set; }

    public GPUBuffer()
    {
        //SILVER: Placeholder for json files?
        GPUBufferName = "RainAddressBuffer";
    }

    public GPUBuffer(Int64 NameOffset, string Name, uint utf16Hash, uint asciiHash)
    {
        GPUBufferNameOffset = NameOffset;
        GPUBufferName = Name;
        GPBFNameUTF16Hash = utf16Hash;
        GPBFNameASCIIHash = asciiHash;
    }
}
