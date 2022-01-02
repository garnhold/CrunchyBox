using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class FileInfoExtensions_Hash
    {
        static public ByteSequence CalculateSHA1(this FileInfo item)
        {
            return HashTypes.SHA1.Calculate(item.ReadAllBytes());
        }

        static public ByteSequence CalculateSHA256(this FileInfo item)
        {
            return HashTypes.SHA256.Calculate(item.ReadAllBytes());
        }
    }
}