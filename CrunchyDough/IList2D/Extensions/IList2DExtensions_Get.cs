using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Get
    {
        static public bool TryGet<T>(this IList2D<T> item, int x, int y, out T value)
        {
            if (item.IsIndexValid(x, y))
            {
                value = item[x, y];
                return true;
            }

            value = default(T);
            return false;
        }
        static public bool TryGet<T>(this IList2D<T> item, IList2DIndex index, out T value)
        {
            return item.TryGet<T>(index.GetX(), index.GetY(), out value);
        }

        static public T Get<T>(this IList2D<T> item, int x, int y, T default_value = default(T))
        {
            T value;

            if (item.TryGet<T>(x, y, out value))
                return value;

            return default_value;
        }
        static public T Get<T>(this IList2D<T> item, IList2DIndex index, T default_value = default(T))
        {
            return item.Get<T>(index.GetX(), index.GetY(), default_value);
        }
    }
}