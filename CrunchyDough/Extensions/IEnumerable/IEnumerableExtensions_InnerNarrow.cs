using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_InnerNarrow
    {
        static public IEnumerable<IEnumerable<T>> InnerNarrow<T>(this IEnumerable<IEnumerable<T>> item, Predicate<T> predicate)
        {
            return item.ConvertGrouped(e => e.Narrow(predicate));
        }
    }
}