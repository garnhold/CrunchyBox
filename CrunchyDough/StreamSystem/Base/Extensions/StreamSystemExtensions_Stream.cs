using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_Stream
    {
        static public AttemptResult WriteStreamTo(this StreamSystem item, string path, Stream source, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.Write(path, delegate(Stream file_stream) {
                file_stream.WriteStream(source);
            }, milliseconds);
        }

        static public AttemptResult AttemptReadIntoStream(this StreamSystem item, string path, Stream destination, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream file_stream) {
                destination.WriteStream(file_stream);
            }, milliseconds);
        }
    }
}