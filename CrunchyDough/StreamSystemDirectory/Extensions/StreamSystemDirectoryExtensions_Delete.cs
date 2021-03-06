using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemDirectoryExtensions_Delete
    {
        static public AttemptResult Delete(this StreamSystemDirectory item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().DeleteDirectory(item.GetPath(), milliseconds);
        }
    }
}