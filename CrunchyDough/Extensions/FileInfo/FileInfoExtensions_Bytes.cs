using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class FileInfoExtensions_Bytes
    {
        static public byte[] ReadAllBytes(this FileInfo item)
        {
            return File.ReadAllBytes(item.FullName);
        }
    }
}