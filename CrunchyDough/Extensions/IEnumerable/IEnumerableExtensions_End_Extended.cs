using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_End_Extended
    {
        static public IEnumerable<T> EndBeforeNull<T>(this IEnumerable<T> item)
        {
            return item.EndBefore(i => i.EqualsEX(null));
        }
    }
}