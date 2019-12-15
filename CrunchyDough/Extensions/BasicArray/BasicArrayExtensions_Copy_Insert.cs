using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class BasicArrayExtensions_Copy_Insert
    {
        static public Array CopyInsert(this Array item, int index, Array array)
        {
            int current_index;
            Array new_array = item.CreateInstance(item.GetLength() + array.GetLength());

            current_index = new_array.CopySubsection(item, 0, 0, index);
            current_index = new_array.CopyFrom(array, current_index);
            current_index = new_array.CopySubsection(item, current_index, index, item.GetLength());
            return new_array;
        }
        static public Array CopyInsert(this Array item, int index, params object[] array)
        {
            return item.CopyInsert(index, (Array)array);
        }
    }
}
