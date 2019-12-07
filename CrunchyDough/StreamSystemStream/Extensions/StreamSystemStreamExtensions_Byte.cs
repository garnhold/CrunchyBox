using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Byte
    {
        static public AttemptResult WriteBytes(this StreamSystemStream item, byte[] bytes, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().WriteBytes(item.GetPath(), bytes, milliseconds);
        }

        static public AttemptResult AttemptReadBytes(this StreamSystemStream item, Process<byte[]> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadBytes(item.GetPath(), process, milliseconds);
        }

        static public AttemptResult AttemptReadBytes(this StreamSystemStream item, out byte[] bytes, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadBytes(item.GetPath(), out bytes, milliseconds);
        }
        static public byte[] ReadBytes(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadBytes(item.GetPath(), milliseconds);
        }

        static public AttemptResult AttemptReadBytes<T>(this StreamSystemStream item, Operation<T, byte[]> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadBytes<T>(item.GetPath(), operation, out output, milliseconds);
        }
        static public T ReadBytes<T>(this StreamSystemStream item, Operation<T, byte[]> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadBytes<T>(item.GetPath(), operation, milliseconds);
        }
    }
}