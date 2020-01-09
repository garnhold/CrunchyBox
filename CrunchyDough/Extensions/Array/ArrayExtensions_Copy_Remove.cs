using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ArrayExtensions_CopyRemove
    {
        static public T[] CopyRemove<T>(this T[] item, int index, int length)
        {
            int current_index;
            T[] new_array = new T[item.Length - length];

            current_index = new_array.CopySubsection(item, 0, 0, index);
            new_array.CopyFrom(item, current_index, index + length);
            return new_array;
        }
        static public T[] CopyRemove<T>(this T[] item, int index)
        {
            return item.CopyRemove(index, 1);
        }
    }
}
