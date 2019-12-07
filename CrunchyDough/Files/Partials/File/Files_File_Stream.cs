using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class Files
    {
        static public AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = DEFAULT_WAIT)
        {
            return Attempter.AttemptFailOnException(delegate(out Stream inner_stream) {
                inner_stream = null;

                if (DoesFileExist(path))
                {
                    try
                    {
                        inner_stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    }
                    catch (FileNotFoundException) { return AttemptResult.Failed; }
                    catch (IOException) { return AttemptResult.Tried; }

                    return AttemptResult.Succeeded;
                }

                return AttemptResult.Failed;
            }, out stream, milliseconds);
        }

        static public AttemptResult OpenStreamForWriting(string path, out Stream stream, long milliseconds = DEFAULT_WAIT)
        {
            return Attempter.AttemptFailOnException(delegate(out Stream inner_stream) {
                inner_stream = null;

                try
                {
                    inner_stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                }
                catch (IOException) { return AttemptResult.Tried; }

                return AttemptResult.Succeeded;
            }, out stream, milliseconds);
        }
    }
}