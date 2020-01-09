using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ArrayExtensions_Copy_Insert
    {
        static public T[] CopyInsert<T>(this T[] item, int index, params T[] array)
        {
            int current_index;
            T[] new_array = new T[item.GetLength() + array.GetLength()];

            current_index = new_array.CopySubsection(item, 0, 0, index);
            current_index = new_array.CopyFrom(array, current_index);
            current_index = new_array.CopySubsection(item, current_index, index, item.GetLength());
            return new_array;
        }
    }
}
