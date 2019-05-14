using System;
using System.IO;

namespace CrunchyDough
{
    static public partial class Filename
    {
        static public string GetAbsolutePath(string path)
        {
            return CleanPath(Path.GetFullPath(path));
        }
    }
}