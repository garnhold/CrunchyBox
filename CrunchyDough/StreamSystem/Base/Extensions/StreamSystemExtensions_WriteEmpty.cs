using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_WriteEmpty
    {
        static public AttemptResult WriteEmpty(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.Write(path, delegate(Stream stream) { }, milliseconds);
        }
    }
}