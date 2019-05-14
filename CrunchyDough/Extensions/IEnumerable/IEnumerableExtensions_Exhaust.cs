using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Exhaust
    {
        static public void Exhaust<T>(this IEnumerable<T> item)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
                while (iterator.MoveNext()) ;
        }
    }
}