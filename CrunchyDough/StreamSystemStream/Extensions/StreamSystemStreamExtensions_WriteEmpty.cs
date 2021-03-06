using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_WriteEmpty
    {
        static public AttemptResult WriteEmpty(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().WriteEmpty(item.GetPath(), milliseconds);
        }
    }
}