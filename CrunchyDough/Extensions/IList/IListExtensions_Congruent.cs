using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Congruent
    {
        static public T GetACongruent<T>(this IList<T> item, int value)
        {
            return item.GetLooped(value.GetACongruent());
        }
    }
}