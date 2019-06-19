using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Percent
    {
        static public int GetPercentIndex<T>(this IList<T> item, float percent)
        {
            return (int)(percent * item.Count);
        }
    }
}