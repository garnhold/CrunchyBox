using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public AttemptResult MoveDirectory(string path, string new_path, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            if (DoesDirectoryExist(path))
            {
                if (overwrite || DoesDirectoryExist(new_path) == false)
                {
                    return Attempter.AttemptFailOnException(delegate() {
                        Directory.Move(path, new_path);

                        return AttemptResult.Succeeded;
                    }, milliseconds);
                }
            }

            return AttemptResult.Failed;
        }
    }
}