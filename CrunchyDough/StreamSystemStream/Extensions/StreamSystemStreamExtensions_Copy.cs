using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Copy
    {
        static public AttemptResult Copy(this StreamSystemStream item, StreamSystemStream dst, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().CopyStream(item.GetPath(), dst.GetStreamSystem(), dst.GetPath(), overwrite, milliseconds);
        }
    }
}