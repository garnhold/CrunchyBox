using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DCellExtensions_Set
    {
        static public void Set<T>(this IList2DCell<T> item, T value)
        {
            item.GetList().SetDropped<T>(item.GetIndex(), value);
        }
    }
}