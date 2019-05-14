using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemStreamExtensions_Stream
    {
        static public AttemptResult WriteStreamTo(this StreamSystemStream item, Stream source, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().WriteStreamTo(item.GetPath(), source, milliseconds);
        }

        static public AttemptResult AttemptReadIntoStream(this StreamSystemStream item, Stream destination, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadIntoStream(item.GetPath(), destination, milliseconds);
        }
    }
}