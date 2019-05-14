using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_CopyTo
    {
        static public void CopyTo<T>(this ICollection<T> item, T[] dst_array)
        {
            item.CopyTo(dst_array, 0);
        }
    }
}