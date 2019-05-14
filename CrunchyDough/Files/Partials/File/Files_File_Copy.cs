using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public AttemptResult CopyFile(string src_filename, string dst_filename, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            if (DoesFileExist(src_filename))
            {
                if (overwrite || DoesFileExist(dst_filename) == false)
                {
                    return Attempter.AttemptFailOnException(delegate() {
                        try
                        {
                            File.Copy(src_filename, dst_filename, overwrite);
                        }
                        catch (FileNotFoundException) { return AttemptResult.Failed; }
                        catch (IOException) { return AttemptResult.Tried; }

                        return AttemptResult.Succeeded;
                    }, milliseconds);
                }

                return AttemptResult.Unneeded;
            }

            return AttemptResult.Failed;
        }

        static public AttemptResult CopyFileOverwriteOld(string src_filename, string dst_filename, long milliseconds = DEFAULT_WAIT)
        {
            if (IsFileNewer(src_filename, dst_filename))
                return CopyFile(src_filename, dst_filename, true, milliseconds);

            return AttemptResult.Unneeded;
        }
    }
}