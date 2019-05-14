using System;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ArrayExtensions_Append
    {
        static public T[] Append<T>(this T[] item, params T[] array)
        {
            T[] new_array = new T[item.GetLength() + array.GetLength()];

            new_array.CopyFrom(item);
            new_array.CopyFrom(array, item.GetLength());
            return new_array;
        }

        static public T[] Prepend<T>(this T[] item, params T[] array)
        {
            return array.Append<T>(item);
        }
    }
}
