using System;
using System.IO;

namespace Crunchy.Dough
{
    static public partial class Filename
    {
        static public string GetDirectory(string path)
        {
            try
            {
                path = CleanPath(Path.GetDirectoryName(path));

                if (path.IsVisible())
                    return path.EnsuredSuffix("/");
            }
            catch (Exception e)
            {
            }

            return "";
        }

        static public string GetParentDirectory(string path)
        {
            return GetDirectory(
                CleanPath(path).TrimSuffix("/")
            );
        }

        static public string GetTopDirectoryName(string path)
        {
            return GetDirectory(path)
                .TrimPrefix(GetParentDirectory(path))
                .TrimSuffix("/");
        }

        static public string GetAbsoluteDirectory(string path)
        {
            return GetDirectory(GetAbsolutePath(path));
        }
    }
}