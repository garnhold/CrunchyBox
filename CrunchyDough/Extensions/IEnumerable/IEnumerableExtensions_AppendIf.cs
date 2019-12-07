using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_AppendIf
    {
        static public IEnumerable<T> AppendIf<T>(this IEnumerable<T> item, bool append, Operation<IEnumerable<T>> operation)
        {
            if (append)
                return item.Append(operation());

            return item;
        }
        static public IEnumerable<T> AppendIf<T>(this IEnumerable<T> item, bool append, IEnumerable<T> to_append)
        {
            return item.AppendIf(append, () => to_append);
        }
        static public IEnumerable<T> AppendIf<T>(this IEnumerable<T> item, bool append, params T[] to_append)
        {
            return item.AppendIf(append, (IEnumerable<T>)to_append);
        }

        static public IEnumerable<T> AppendIf<T>(this IEnumerable<T> item, bool append, Operation<T> operation)
        {
            if (append)
                return item.Append(operation());

            return item;
        }

        static public IEnumerable<T> PrependIf<T>(this IEnumerable<T> item, bool prepend, Operation<IEnumerable<T>> operation)
        {
            if (prepend)
                return item.Prepend(operation());

            return item;
        }
        static public IEnumerable<T> PrependIf<T>(this IEnumerable<T> item, bool prepend, IEnumerable<T> to_prepend)
        {
            return item.PrependIf(prepend, () => to_prepend);
        }
        static public IEnumerable<T> PrependIf<T>(this IEnumerable<T> item, bool prepend, params T[] to_prepend)
        {
            return item.PrependIf(prepend, (IEnumerable<T>)to_prepend);
        }

        static public IEnumerable<T> PrependIf<T>(this IEnumerable<T> item, bool prepend, Operation<T> operation)
        {
            if (prepend)
                return item.Prepend(operation());

            return item;
        }
    }
}