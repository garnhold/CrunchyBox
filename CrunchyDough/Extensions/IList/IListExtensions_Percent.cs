using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Percent
    {
        static public int GetPercentIndex<T>(this IList<T> item, float percent)
        {
            return (int)(percent * item.Count);
        }
    }
}