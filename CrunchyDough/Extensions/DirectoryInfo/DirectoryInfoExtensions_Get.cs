using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class DirectoryInfoExtensions_Get
    {
        static public FileInfo GetFile(this DirectoryInfo item, string name)
        {
            return item.EnumerateFiles(name)
                .FindFirst(f => f.Name == name);
        }
    }
}