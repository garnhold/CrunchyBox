using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_Object
    {
        static public AttemptResult WriteObject(this StreamSystem item, string path, object to_write, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.Write(path, delegate(Stream stream) {
                if (to_write != null)
                    stream.WriteObject(to_write);
            }, milliseconds);
        }

        static public AttemptResult AttemptReadObject(this StreamSystem item, string path, out object obj, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream, out object inner) {
                if (stream.Length > 0)
                    return stream.TryReadObject(out inner);

                inner = null;
                return false;
            }, out obj, milliseconds);
        }
        static public object ReadObject(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            object output;

            item.AttemptReadObject(path, out output, milliseconds);
            return output;
        }

        static public AttemptResult AttemptReadObject<T>(this StreamSystem item, string path, out T obj, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            object general_obj;
            AttemptResult result = item.AttemptReadObject(path, out general_obj, milliseconds);

            obj = general_obj.Convert<T>();
            return result;
        }
        static public T ReadObject<T>(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T output;

            item.AttemptReadObject<T>(path, out output, milliseconds);
            return output;
        }

        static public AttemptResult AttemptReadObjectIfExists<T>(this StreamSystem item, string path, ref T to_read, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (item.DoesStreamExist(path))
                return item.AttemptReadObject<T>(path, out to_read, milliseconds);

            return AttemptResult.Unneeded;
        }
    }
}