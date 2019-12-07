using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crunchy.Dough
{
    static public class StreamExtensions_Object
    {
        static public void WriteObject(this Stream item, object to_write)
        {
            new BinaryFormatter().Serialize(item, to_write);
        }

        static public bool TryReadObject(this Stream item, out object output)
        {
            try
            {
                output = new BinaryFormatter().Deserialize(item);
                return true;
            }
            catch (Exception ex)
            {
            }

            output = null;
            return false;
        }
        static public bool TryReadObject<T>(this Stream item, out T output)
        {
            object temp;

            if (item.TryReadObject(out temp))
            {
                if (temp.Convert<T>(out output))
                    return true;
            }

            output = default(T);
            return false;
        }

        static public object ReadObject(this Stream item)
        {
            object obj;

            item.TryReadObject(out obj);
            return obj;
        }
        static public T ReadObject<T>(this Stream item)
        {
            return item.ReadObject().Convert<T>();
        }
    }
}