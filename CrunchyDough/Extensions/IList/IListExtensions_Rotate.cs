using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Rotate
    {
        static public IEnumerable<T> Rotate<T>(this IList<T> item, int start)
        {
            return item.Offset(start).Append(item.Truncate(start));
        }

        static public IEnumerable<T> RotateHalfway<T>(this IList<T> item)
        {
            return item.Rotate<T>(item.Count / 2);
        }
    }
}