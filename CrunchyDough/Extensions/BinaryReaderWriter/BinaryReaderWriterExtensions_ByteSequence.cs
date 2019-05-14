using System;
using System.IO;

namespace CrunchyDough
{
    static public class BinaryReaderWriterExtensions_ByteSequence
    {
        static public void Write(this BinaryWriter item, ByteSequence value)
        {
            item.Write(value.GetSize());
            item.Write(value.GetBytes());
        }

        static public ByteSequence ReadByteSequence(this BinaryReader item)
        {
            int size = item.ReadInt32();

            return new ByteSequence(item.ReadBytes(size));
        }
    }
}