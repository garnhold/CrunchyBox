using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemStreamExtensions_Open
    {
        static public AttemptResult OpenWrite(this StreamSystemStream item, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().OpenStreamForWriting(item.GetPath(), out stream, milliseconds);
        }

        static public AttemptResult OpenRead(this StreamSystemStream item, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().OpenStreamForReading(item.GetPath(), out stream, milliseconds);
        }
    }
}