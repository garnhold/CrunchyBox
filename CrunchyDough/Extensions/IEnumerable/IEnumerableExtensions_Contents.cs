using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Contents
    {
        static public IEnumerable<T> ContentsEquality<T>(this IEnumerable<T> item)
        {
            return new ContentsEnumerable<T>(item);
        }
    }
}