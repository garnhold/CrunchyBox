using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_Convert
    {
        static public bool Convert<T>(this object item, out T output, bool allow_null_object = false)
        {
            if (item is T)
            {
                output = (T)item;
                return true;
            }

            output = default(T);

            if (allow_null_object)
            {
                if (item == null)
                    return true;
            }

            return false;
        }
        static public T Convert<T>(this object item)
        {
            T output;

            item.Convert<T>(out output);
            return output;
        }

        static public bool CanConvert(this object item, Type type, bool allow_null_object = false)
        {
            if (type != null)
            {
                if (type.IsAssignableFrom(item.GetTypeEX()))
                    return true;

                if (allow_null_object)
                {
                    if (item == null)
                        return true;
                }
            }

            return false;
        }
    }
}