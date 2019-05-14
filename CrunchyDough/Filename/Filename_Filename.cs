using System;
using System.IO;

namespace CrunchyDough
{
    static public partial class Filename
    {
        static public string GetFilenameWithExtension(string path)
        {
            return Path.GetFileName(path);
        }

        static public string GetFilenameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        static public string SetFilenameWithExtension(string path, string filename)
        {
            return Combine(GetDirectory(path), GetFilenameWithExtension(filename));
        }

        static public string SetFilenameWithoutExtension(string path, string filename)
        {
            return SetExtension(SetFilenameWithExtension(path, filename), GetExtension(path));
        }

        static public string AddFilenameSuffix(string path, string suffix)
        {
            return SetFilenameWithoutExtension(path, GetFilenameWithoutExtension(path) + suffix);
        }
    }
}