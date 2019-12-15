using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ArrayExtensions_Copy_Append
    {
        static public T[] CopyAppend<T>(this T[] item, params T[] array)
        {
            T[] new_array = new T[item.GetLength() + array.GetLength()];

            new_array.CopyFrom(item);
            new_array.CopyFrom(array, item.GetLength());
            return new_array;
        }

        static public T[] CopyPrepend<T>(this T[] item, params T[] array)
        {
            return array.CopyAppend<T>(item);
        }
    }
}
