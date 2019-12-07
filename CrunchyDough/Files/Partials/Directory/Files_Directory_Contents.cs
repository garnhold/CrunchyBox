using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class Files
    {
        static public IEnumerable<string> GetDirectorysInDirectory(string directory)
        {
            return Directory.GetDirectories(Filename.GetDirectory(directory), "*", SearchOption.TopDirectoryOnly)
                .Skip(s => s == "." || s == "..")
                .Convert(s => Filename.CleanPath(s + "/"));
        }
        static public IEnumerable<string> GetRelativeDirectorysInDirectory(string directory)
        {
            return GetDirectorysInDirectory(directory)
                .Convert(d => Filename.GetRelativePath(d, directory));
        }

        static public IEnumerable<string> GetFilenamesInDirectory(string directory)
        {
            return Directory.GetFiles(Filename.GetDirectory(directory), "*", SearchOption.TopDirectoryOnly)
                .Convert(s => Filename.CleanPath(s));
        }
        static public IEnumerable<string> GetRelativeFilenamesInDirectory(string directory)
        {
            return GetFilenamesInDirectory(directory)
                .Convert(f => Filename.GetRelativePath(f, directory));
        }
    }
}