using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_PrepareMultipass
    {
        static public IEnumerable<T> PrepareMultipass<T>(this IEnumerable<T> item)
        {
            if (item is ICollection<T>)
                return item;

            if (item is ICollection)
                return item;

            return item.ToList();
        }
    }
}