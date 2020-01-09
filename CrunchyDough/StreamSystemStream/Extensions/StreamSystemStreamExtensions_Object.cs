using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Object
    {
        static public AttemptResult WriteObject(this StreamSystemStream item, object to_write, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().WriteObject(item.GetPath(), to_write, milliseconds);
        }

        static public AttemptResult AttemptReadObject(this StreamSystemStream item, out object obj, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadObject(item.GetPath(), out obj, milliseconds);
        }
        static public object ReadObject(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadObject(item.GetPath(), milliseconds);
        }

        static public AttemptResult AttemptReadObject<T>(this StreamSystemStream item, out T obj, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadObject<T>(item.GetPath(), out obj, milliseconds);
        }
        static public T ReadObject<T>(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadObject<T>(item.GetPath(), milliseconds);
        }

        static public AttemptResult AttemptReadObjectIfExists<T>(this StreamSystemStream item, ref T to_read, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadObjectIfExists<T>(item.GetPath(), ref to_read, milliseconds);
        }
    }
}