using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ICollectionExtensions_Ensure
    {
        static public void EnsureSizeWithEmptys<T>(this ICollection<T> item, int size)
        {
            if (size > item.Count)
                item.AddEmptys(size - item.Count);
        }
    }
}