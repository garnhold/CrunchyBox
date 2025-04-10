using System;
using System.IO;

namespace Crunchy.Dough
{
    static public partial class Filename
    {
        static public bool IsPathAbsolute(string path)
        {
            if (Filename.GetAbsolutePath(path) == path)
                return true;

            return false;
        }
        static public bool IsPathRelative(string path)
        {
            if (Filename.IsPathAbsolute(path) == false)
                return true;

            return false;
        }
    }
}