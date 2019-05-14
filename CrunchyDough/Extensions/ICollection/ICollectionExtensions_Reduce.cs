using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_Reduce
    {
        static public void Reduce<T>(this ICollection<T> item, Predicate<T> predicate)
        {
            item.RemoveAll(i => predicate(i) == false);
        }
    }
}