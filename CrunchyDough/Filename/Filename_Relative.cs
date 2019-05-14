using System;
using System.IO;

namespace CrunchyDough
{
    static public partial class Filename
    {
        static public string GetRelativePath(string path, string base_path)
        {
            path = GetAbsolutePath(path);
            base_path = GetAbsoluteDirectory(base_path);

            return path.TrimPrefix(base_path);
        }

        static public string GetRelativePath(string path)
        {
            return GetRelativePath(path, Directory.GetCurrentDirectory());
        }
    }
}