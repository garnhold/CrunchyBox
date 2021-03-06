using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Pop
    {
        static public T PopAt<T>(this IList<T> item, int index)
        {
            T element = item.Get(index);

            item.RemoveAt(index);
            return element;
        }

        static public T PopFirst<T>(this IList<T> item)
        {
            return item.PopAt(0);
        }

        static public T PopLast<T>(this IList<T> item)
        {
            return item.PopAt(item.GetFinalIndex());
        }
    }
}