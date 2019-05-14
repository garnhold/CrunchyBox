using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public AttemptResult CreateDirectory(string directory, long milliseconds = DEFAULT_WAIT)
        {
            if (DoesDirectoryExist(directory) == false)
            {
                return Attempter.AttemptFailOnException(delegate() {
                    DirectoryInfo info = Directory.CreateDirectory(directory);
                    if (info != null)
                        return AttemptResult.Succeeded;

                    return AttemptResult.Failed;
                }, milliseconds);
            }

            return AttemptResult.Unneeded;
        }
    }
}