using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ICollectionExtensions_Pop
    {
        static public T PopFirst<T>(this ICollection<T> item)
        {
            T sub_item = item.GetFirst();

            item.Remove(sub_item);
            return sub_item;
        }

        static public T PopFirst<T>(this ICollection<T> item, Predicate<T> predicate)
        {
            T sub_item = item.FindFirst(predicate);

            item.Remove(sub_item);
            return sub_item;
        }
    }
}