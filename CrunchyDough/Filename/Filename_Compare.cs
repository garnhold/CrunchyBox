using System;
using System.IO;

namespace Crunchy.Dough
{
    static public partial class Filename
    {
        static public bool ArePathsEquivalent(string path1, string path2)
        {
            if (path1 == path2)
                return true;

            if (path1.IsVisible() && path2.IsVisible())
            {
                if(GetAbsolutePath(path1) == GetAbsolutePath(path2))
                    return true;
            }

            return false;
        }
    }
}