using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_AppendIfNot
    {
        static public IEnumerable<T> AppendIfNot<T>(this IEnumerable<T> item, bool append, IEnumerable<T> to_append)
        {
            return item.AppendIf(append == false, to_append);
        }
        static public IEnumerable<T> AppendIfNot<T>(this IEnumerable<T> item, bool append, params T[] to_append)
        {
            return item.AppendIfNot(append, (IEnumerable<T>)to_append);
        }

        static public IEnumerable<T> PrependIfNot<T>(this IEnumerable<T> item, bool prepend, IEnumerable<T> to_prepend)
        {
            return item.PrependIf(prepend == false, to_prepend);
        }
        static public IEnumerable<T> PrependIfNot<T>(this IEnumerable<T> item, bool prepend, params T[] to_prepend)
        {
            return item.PrependIfNot(prepend, (IEnumerable<T>)to_prepend);
        }
    }
}