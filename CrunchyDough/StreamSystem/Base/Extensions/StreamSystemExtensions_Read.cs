using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemExtensions_Read
    {
        static public AttemptResult AttemptRead(this StreamSystem item, string path, TryProcess<Stream> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            Stream stream;
            AttemptResult result = item.OpenStreamForReading(path, out stream, milliseconds);

            using (stream)
            {
                if (result.IsDesired())
                {
                    if (process(stream) == false)
                        result = AttemptResult.Failed;
                }
            }

            return result;
        }
        static public AttemptResult AttemptRead(this StreamSystem item, string path, Process<Stream> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream) {
                process(stream);

                return true;
            }, milliseconds);
        }

        static public AttemptResult AttemptRead<T>(this StreamSystem item, string path, TryOperation<T, Stream> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T temp = default(T);

            AttemptResult result = item.AttemptRead(path, delegate(Stream stream) {
                return operation(stream, out temp);
            }, milliseconds);

            output = temp;
            return result;
        }
        static public T Read<T>(this StreamSystem item, string path, TryOperation<T, Stream> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T output;

            item.AttemptRead<T>(path, operation, out output, milliseconds);
            return output;
        }

        static public AttemptResult AttemptRead<T>(this StreamSystem item, string path, Operation<T, Stream> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream, out T inner) {
                inner = operation(stream);

                return true;
            }, out output, milliseconds);
        }
        static public T Read<T>(this StreamSystem item, string path, Operation<T, Stream> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T output;

            item.AttemptRead<T>(path, operation, out output, milliseconds);
            return output;
        }
    }
}