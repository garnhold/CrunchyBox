using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_AppendIf
    {
        static public IEnumerable<T> AppendIf<T>(this IEnumerable<T> item, bool append, IEnumerable<T> to_append)
        {
            if (append)
                return item.Append(to_append);

            return item;
        }
        static public IEnumerable<T> AppendIf<T>(this IEnumerable<T> item, bool append, params T[] to_append)
        {
            return item.AppendIf(append, (IEnumerable<T>)to_append);
        }

        static public IEnumerable<T> PrependIf<T>(this IEnumerable<T> item, bool prepend, IEnumerable<T> to_prepend)
        {
            if (prepend)
                return item.Prepend(to_prepend);

            return item;
        }
        static public IEnumerable<T> PrependIf<T>(this IEnumerable<T> item, bool prepend, params T[] to_prepend)
        {
            return item.PrependIf(prepend, (IEnumerable<T>)to_prepend);
        }
    }
}