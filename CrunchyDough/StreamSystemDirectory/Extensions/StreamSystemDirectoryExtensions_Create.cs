using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemDirectoryExtensions_Create
    {
        static public AttemptResult Create(this StreamSystemDirectory item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().CreateDirectory(item.GetPath(), milliseconds);
        }
    }
}