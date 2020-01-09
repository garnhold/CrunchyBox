using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class BasicArrayExtensions_CopyRemove
    {
        static public Array CopyRemove(this Array item, int index, int length)
        {
            int current_index;
            Array new_array = item.CreateInstance(item.GetLength() - length);

            current_index = new_array.CopySubsection(item, 0, 0, index);
            new_array.CopyFrom(item, current_index, index + length);
            return new_array;
        }
        static public Array CopyRemove(this Array item, int index)
        {
            return item.CopyRemove(index, 1);
        }
    }
}
