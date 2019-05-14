using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_InnerExpand
    {
        static public IEnumerable<IEnumerable<object>> InnerExpand<J, T>(this IEnumerable<IEnumerable<J>> item, Operation<object, T> operation)
        {
            return item.ConvertGrouped(e => e.Expand(operation));
        }
    }
}