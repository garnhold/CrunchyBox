using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class BinaryReaderWriterExtensions_StretchedHash
    {
        static public void Write(this BinaryWriter item, StretchedHash value)
        {
            item.Write(value.GetHash());
            item.Write(value.GetSalt());
            item.Write(value.GetIterations());
        }

        static public StretchedHash ReadStretchedHash(this BinaryReader item)
        {
            ByteSequence hash = item.ReadByteSequence();
            ByteSequence salt = item.ReadByteSequence();
            int iterations = item.ReadInt32();

            return new StretchedHash(hash, salt, iterations);
        }
    }
}