using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_InnerUnique
    {
        static public IEnumerable<IEnumerable<T>> InnerUnique<T>(this IEnumerable<IEnumerable<T>> item)
        {
            return item.ConvertGrouped(e => e.Unique());
        }
    }
}