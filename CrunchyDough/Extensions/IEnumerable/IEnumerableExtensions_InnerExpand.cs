using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_InnerExpand
    {
        static public IEnumerable<IEnumerable<object>> InnerExpand<J, T>(this IEnumerable<IEnumerable<J>> item, Operation<object, T> operation)
        {
            return item.Convert(e => e.Expand(operation));
        }
    }
}