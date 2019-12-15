using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class BasicArrayExtensions_Copy_Append
    {
        static public Array CopyAppend(this Array item, Array array)
        {
            Array new_array = item.CreateInstance(item.GetLength() + array.GetLength());

            new_array.CopyFrom(item);
            new_array.CopyFrom(array, item.GetLength());
            return new_array;
        }
        static public Array CopyAppend(this Array item, params object[] array)
        {
            return item.CopyAppend(item, (Array)array);
        }

        static public Array CopyPrepend(this Array item, Array array)
        {
            return array.CopyAppend(item);
        }
        static public Array CopyPrepend(this Array item, params object[] array)
        {
            return item.CopyPrepend((Array)array);
        }
    }
}
