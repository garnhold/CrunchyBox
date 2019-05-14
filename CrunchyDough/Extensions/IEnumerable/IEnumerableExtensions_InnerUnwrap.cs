using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_InnerUnwrap
    {
        static public IEnumerable<IEnumerable<object>> InnerUnwrap<J, T>(this IEnumerable<IEnumerable<J>> item, Operation<object, T> operation)
        {
            return item.ConvertGrouped(e => e.Unwrap(operation));
        }
    }
}