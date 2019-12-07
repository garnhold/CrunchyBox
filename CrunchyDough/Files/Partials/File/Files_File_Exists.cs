using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class Files
    {
        static public bool DoesFileExist(string filename)
        {
            if (File.Exists(filename))
                return true;

            return false;
        }

        static public bool TryGetUnusedFilename(string basename, int suffix_length, int max_number_trys, out string filename)
        {
            int number_trys = 0;

            filename = basename;

            while (DoesFileExist(filename))
            {
                if (number_trys >= max_number_trys)
                    return false;

                filename = Filename.AddFilenameSuffix(basename, Strings.PseudoRandom(suffix_length));
            }

            return true;
        }
        static public string GetUnusedFilename(string basename)
        {
            string filename;

            if (TryGetUnusedFilename(basename, 10, 32, out filename))
                return filename;

            throw new TimeoutException("Unable to find an unused filename for " + basename);
        }
    }
}