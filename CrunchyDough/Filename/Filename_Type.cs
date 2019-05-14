using System;
using System.IO;

namespace CrunchyDough
{
    static public partial class Filename
    {
        static private Uri GetUri(string filename)
        {
            Uri uri;

            if (Uri.TryCreate(filename, UriKind.RelativeOrAbsolute, out uri))
                return uri;

            return null;
        }

        static public bool IsPathRelative(string path)
        {
            return GetUri(path).IfNotNull(u => u.IsAbsoluteUri == false && u.IsFile, false);
        }

        static public bool IsPathAbsolute(string path)
        {
            return GetUri(path).IfNotNull(u => u.IsAbsoluteUri == true && u.IsFile, false);
        }
    }
}