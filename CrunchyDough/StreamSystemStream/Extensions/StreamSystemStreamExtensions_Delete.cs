using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Delete
    {
        static public AttemptResult Delete(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().DeleteStream(item.GetPath(), milliseconds);
        }
    }
}