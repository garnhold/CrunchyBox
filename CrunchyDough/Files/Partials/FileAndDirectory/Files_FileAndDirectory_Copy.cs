using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public void CopyFileOrDirectory(string src, string dst, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            if (DoesFileExist(src))
                CopyFile(src, dst, overwrite, milliseconds);
            else if (DoesDirectoryExist(src))
                CopyDirectory(src, dst, overwrite, milliseconds);
        }

        static public void CopyFileOrDirectoryToDirectory(string src, string dst_directory, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            CopyFileOrDirectory(src, Filename.MakeFilename(dst_directory, src), overwrite, milliseconds);
        }

        static public void CopyFileOrDirectoryBetweenDirectorys(string src_directory, string dst_directory, string name, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            CopyFileOrDirectory(Filename.MakeFilename(src_directory, name), Filename.MakeFilename(dst_directory, name), overwrite, milliseconds);
        }
    }
}