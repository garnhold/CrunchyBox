using System;
using System.IO;

namespace Crunchy.Dough
{
    static public partial class Filename
    {
        static public string Combine(string path1, string path2)
        {
            return CleanPath(Path.Combine(path1, path2));
        }

        static public string ForwardCombine(string path1, string path2)
        {
            return Combine(
                path1,
                CleanPath(path2).Remove("../").TrimPrefix("/")
            );
        }
    }
}