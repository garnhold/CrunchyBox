using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Reverse
    {
        static public IEnumerable<T> Reverse<T>(this IEnumerable<T> item)
        {
            return item.ToList().GetReverse();
        }
    }
}