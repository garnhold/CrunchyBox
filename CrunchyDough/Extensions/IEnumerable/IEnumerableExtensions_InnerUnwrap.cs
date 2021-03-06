using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_InnerUnwrap
    {
        static public IEnumerable<IEnumerable<object>> InnerUnwrap<J, T>(this IEnumerable<IEnumerable<J>> item, Operation<object, T> operation)
        {
            return item.Convert(e => e.Unwrap(operation));
        }
    }
}