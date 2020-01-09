using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Read
    {
        static public AttemptResult AttemptRead(this StreamSystemStream item, TryProcess<Stream> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptRead(item.GetPath(), process, milliseconds);
        }
        static public AttemptResult AttemptRead(this StreamSystemStream item, Process<Stream> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptRead(item.GetPath(), process, milliseconds);
        }

        static public AttemptResult AttemptRead<T>(this StreamSystemStream item, TryOperation<T, Stream> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptRead<T>(item.GetPath(), operation, out output, milliseconds);
        }
        static public T Read<T>(this StreamSystemStream item, TryOperation<T, Stream> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().Read<T>(item.GetPath(), operation, milliseconds);
        }

        static public AttemptResult AttemptRead<T>(this StreamSystemStream item, Operation<T, Stream> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptRead<T>(item.GetPath(), operation, out output, milliseconds);
        }
        static public T Read<T>(this StreamSystemStream item, Operation<T, Stream> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().Read<T>(item.GetPath(), operation, milliseconds);
        }
    }
}