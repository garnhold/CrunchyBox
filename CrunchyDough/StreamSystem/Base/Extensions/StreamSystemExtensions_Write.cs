using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemExtensions_Write
    {
        static public AttemptResult Write(this StreamSystem item, string path, AttemptProcess<Stream> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            Stream stream;
            AttemptResult result = item.OpenStreamForWriting(path, out stream, milliseconds);

            using (stream)
            {
                if (result.IsDesired())
                    return process(stream);
            }

            return result;
        }

        static public AttemptResult Write(this StreamSystem item, string path, Process<Stream> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.Write(path, delegate(Stream stream) {
                process(stream);
                return AttemptResult.Succeeded;
            }, milliseconds);
        }
    }
}