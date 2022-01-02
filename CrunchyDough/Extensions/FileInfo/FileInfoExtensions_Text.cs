using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class FileInfoExtensions_Text
    {
        static public string ReadAllText(this FileInfo item)
        {
            return File.ReadAllText(item.FullName);
        }
    }
}