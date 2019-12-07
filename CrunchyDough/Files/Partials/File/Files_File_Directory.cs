using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class Files
    {
        static public AttemptResult RenameFileInDirectory(string directory, string filename, string new_filename, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            return RenameFile(Filename.MakeFilename(directory, filename), new_filename, overwrite, milliseconds);
        }

        static public AttemptResult DeleteFileInDirectory(string directory, string filename, long milliseconds = DEFAULT_WAIT)
        {
            return DeleteFile(Filename.MakeFilename(directory, filename), milliseconds);
        }

        static public AttemptResult CopyFileToDirectory(string src_filename, string dst_directory, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            return CopyFile(src_filename, Filename.MakeFilename(dst_directory, src_filename), overwrite, milliseconds);
        }
        static public AttemptResult CopyFileBetweenDirectorys(string src_directory, string dst_directory, string filename, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            return CopyFile(Filename.MakeFilename(src_directory, filename), Filename.MakeFilename(dst_directory, filename), overwrite, milliseconds);
        }

        static public AttemptResult CopyFileToDirectoryOverwriteOld(string src_filename, string dst_directory, long milliseconds = DEFAULT_WAIT)
        {
            return CopyFileOverwriteOld(src_filename, Filename.MakeFilename(dst_directory, src_filename), milliseconds);
        }
        static public AttemptResult CopyFileBetweenDirectorysOverwriteOld(string src_directory, string dst_directory, string filename, long milliseconds = DEFAULT_WAIT)
        {
            return CopyFileOverwriteOld(Filename.MakeFilename(src_directory, filename), Filename.MakeFilename(dst_directory, filename), milliseconds);
        }
    }
}