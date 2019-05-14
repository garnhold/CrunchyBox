using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public AttemptResult CopyDirectory(string src_directory, string dst_directory, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            if (CreateDirectory(dst_directory, milliseconds).IsDesired())
                return CopyDirectoryContents(src_directory, dst_directory, overwrite, milliseconds);

            return AttemptResult.Failed;
        }

        static public AttemptResult CopyDirectoryToDirectory(string src_directory, string dst_directory, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            return CopyDirectory(src_directory, Filename.MakeFilename(dst_directory, src_directory), overwrite, milliseconds);
        }

        static public AttemptResult CopyDirectoryBetweenDirectorys(string src_directory, string dst_directory, string directoryname, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            return CopyDirectory(Filename.MakeFilename(src_directory, directoryname), Filename.MakeFilename(dst_directory, directoryname), overwrite, milliseconds);
        }

        static public AttemptResult CopyDirectoryContents(string src_directory, string dst_directory, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            AttemptResult result = AttemptResult.Succeeded;

            result = Directory.GetFiles(src_directory).Apply(result, 
                (r, f) => r.GetAbsorbed(
                    CopyFileBetweenDirectorys(src_directory, dst_directory, f, overwrite, milliseconds)
                )
            );

            result = Directory.GetDirectories(src_directory).Apply(result,
                (r, d) => r.GetAbsorbed(
                    CopyDirectoryBetweenDirectorys(src_directory, dst_directory, d, overwrite, milliseconds)
                )
            );

            return result;
        }
    }
}