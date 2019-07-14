using System;
using System.IO;

namespace CrunchyDough
{
    static public partial class Filename
    {
        static public bool HasExtension(string path)
        {
            if (GetExtension(path).IsVisible())
                return true;

            return false;
        }

        static public string GetExtension(string path)
        {
            return Path.GetExtension(path).TrimPrefix(".");
        }

        static public string GetPathWithoutExtension(string path)
        {
            return Combine(GetDirectory(path), GetFilenameWithoutExtension(path));
        }

        static public string AddExtension(string path, string extension)
        {
            return path + "." + extension;
        }

        static public string SetExtension(string path, string extension)
        {
            return AddExtension(GetPathWithoutExtension(path), extension);
        }
    }
}