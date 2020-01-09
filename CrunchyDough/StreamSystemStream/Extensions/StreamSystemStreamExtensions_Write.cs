using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Write
    {
        static public AttemptResult Write(this StreamSystemStream item, AttemptProcess<Stream> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().Write(item.GetPath(), process, milliseconds);
        }

        static public AttemptResult Write(this StreamSystemStream item, Process<Stream> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().Write(item.GetPath(), process, milliseconds);
        }
    }
}