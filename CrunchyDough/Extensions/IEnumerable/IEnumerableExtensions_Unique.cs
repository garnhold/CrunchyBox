using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Unique
    {
        static public IEnumerable<T> Unique<T>(this IEnumerable<T> item)
        {
            return item.SkipDuplicates();
        }
    }
}