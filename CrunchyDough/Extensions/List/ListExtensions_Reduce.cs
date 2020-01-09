using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ListExtensions_Reduce
    {
        static public void Reduce<T>(this List<T> item, Predicate<T> predicate)
        {
            item.RemoveAll(i => predicate(i) == false);
        }
    }
}