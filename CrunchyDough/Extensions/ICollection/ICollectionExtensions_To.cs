using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_To
    {
        static public T[] ToArray<T>(this ICollection<T> item)
        {
            T[] array = new T[item.Count];

            item.CopyTo(array);
            return array;
        }
    }
}