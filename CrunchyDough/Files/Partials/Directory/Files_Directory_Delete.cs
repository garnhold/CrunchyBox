using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public AttemptResult DeleteDirectory(string directory, long milliseconds = DEFAULT_WAIT)
        {
            if (DoesDirectoryExist(directory))
            {
                Directory.Delete(directory, true);

                return AttemptResult.Succeeded;
            }

            return AttemptResult.Unneeded;
        }
    }
}