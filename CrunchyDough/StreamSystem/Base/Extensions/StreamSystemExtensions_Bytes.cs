using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemExtensions_Bytes
    {
        static public AttemptResult WriteBytes(this StreamSystem item, string path, byte[] bytes, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.Write(path, delegate(Stream stream) {
                stream.WriteBytes(bytes);
            }, milliseconds);
        }

        static public AttemptResult AttemptReadBytes(this StreamSystem item, string path, Process<byte[]> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream) {
                process(stream.ReadBytes());
            }, milliseconds);
        }

        static public AttemptResult AttemptReadBytes(this StreamSystem item, string path, out byte[] bytes, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream) {
                return stream.ReadBytes();
            }, out bytes, milliseconds);
        }
        static public byte[] ReadBytes(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            byte[] output;

            item.AttemptReadBytes(path, out output, milliseconds);
            return output;
        }

        static public AttemptResult AttemptReadBytes<T>(this StreamSystem item, string path, Operation<T, byte[]> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            byte[] bytes;
            AttemptResult result = item.AttemptReadBytes(path, out bytes, milliseconds);

            if (result.IsDesired())
                output = operation(bytes);
            else
                output = default(T);

            return result;
        }
        static public T ReadBytes<T>(this StreamSystem item, string path, Operation<T, byte[]> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T output;

            item.AttemptReadBytes<T>(path, operation, out output, milliseconds);
            return output;
        }
    }
}