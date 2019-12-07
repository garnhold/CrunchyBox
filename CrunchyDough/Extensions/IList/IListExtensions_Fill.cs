using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Fill
    {
        static public void Fill<T>(this IList<T> item, Operation<T, int> operation)
        {
            for (int i = 0; i < item.Count; i++)
                item[i] = operation(i);
        }

        static public void Fill<T>(this IList<T> item, Operation<T> operation)
        {
            item.Fill(i => operation());
        }

        static public void Fill<T>(this IList<T> item, T sub_item)
        {
            item.Fill(() => sub_item);
        }

        static public void Fill<T>(this IList<T> item)
        {
            item.Fill(default(T));
        }
    }
}