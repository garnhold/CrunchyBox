using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class FiltererExtensions
    {
        static public bool Filter<T>(this IEnumerable<Filterer<T>> item, T to_check)
        {
            if(item.AreAll(f => f.Filter(to_check)))
                return true;

            return false;
        }
    }
}