using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ObjectExtensions_IEnumerable_Append
    {
        static public IEnumerable<object> AppendNonNull(this IEnumerable<object> item, object to_append)
        {
            return item.AppendIf(to_append.IsNotNull(), to_append);
        }

        static public IEnumerable<object> PrependNonNull(this IEnumerable<object> item, object to_prepend)
        {
            return item.PrependIf(to_prepend.IsNotNull(), to_prepend);
        }
    }
}