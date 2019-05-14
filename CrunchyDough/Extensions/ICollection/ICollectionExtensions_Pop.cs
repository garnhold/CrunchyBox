using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_Pop
    {
        static public T Pop<T>(this ICollection<T> item)
        {
            T sub_item = item.GetFirst();

            item.Remove(sub_item);
            return sub_item;
        }
    }
}