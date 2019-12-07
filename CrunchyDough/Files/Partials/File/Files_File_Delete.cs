using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class Files
    {
        static public AttemptResult DeleteFile(string filename, long milliseconds = DEFAULT_WAIT)
        {
            if (DoesFileExist(filename))
            {
                return Attempter.AttemptFailOnException(delegate() {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException) { return AttemptResult.Tried; }

                    return AttemptResult.Succeeded;
                }, milliseconds);
            }

            return AttemptResult.Unneeded;
        }   
    }
}