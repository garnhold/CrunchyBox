using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_Convert_ToType
    {
        static public bool ConvertToType(this object item, Type type, out object output)
        {
            if (item != null)
            {
                if (type.IsAssignableFrom(item.GetType()))
                {
                    output = item;
                    return true;
                }
            }

            output = null;
            return false;
        }
        static public object ConvertToType(this object item, Type type)
        {
            object output;

            item.ConvertToType(type, out output);
            return output;
        }
    }
}