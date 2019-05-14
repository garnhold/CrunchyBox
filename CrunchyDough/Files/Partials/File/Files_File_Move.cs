using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public AttemptResult MoveFile(string src_filename, string dst_filename, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            if (DoesFileExist(src_filename))
            {
                if (overwrite || DoesFileExist(dst_filename) == false)
                {
                    DeleteFile(dst_filename);

                    return Attempter.AttemptFailOnException(delegate() {
                        File.Move(src_filename, dst_filename);

                        return AttemptResult.Succeeded;
                    }, milliseconds);
                }
            }

            return AttemptResult.Failed;
        }
    }
}