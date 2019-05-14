using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_CopyClear
    {
        static public IEnumerable<T> CopyClear<T>(this ICollection<T> item)
        {
            List<T> copy = item.ToList();

            item.Clear();
            return copy;
        }
    }
}