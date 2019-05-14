using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Dropped
    {
        static public void SetDropped<T>(this IList<T> item, int index, T value)
        {
            if (item.IsIndexValid(index))
                item[index] = value;
        }

        static public T GetDropped<T>(this IList<T> item, int index)
        {
            if (item.IsIndexValid(index))
                return item[index];

            return default(T);
        }
    }
}