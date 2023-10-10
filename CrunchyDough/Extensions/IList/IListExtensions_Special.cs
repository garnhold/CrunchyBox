using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Special
    {
        static public void SetFirst<T>(this IList<T> item, T value)
        {
            if (item != null)
            {
                if (item.Count >= 1)
                    item[0] = value;
            }
        }

        static public void SetLast<T>(this IList<T> item, T value)
        {
            if (item != null)
            {
                if (item.Count >= 1)
                    item[item.Count - 1] = value;
            }
        }
    }
}