using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Dropped
    {
        static public T GetDropped<T>(this IList2D<T> item, int x, int y)
        {
            if (item.IsIndexValid(x, y))
                return item[x, y];

            return default(T);
        }
        static public T GetDropped<T>(this IList2D<T> item, VectorI2 index)
        {
            return item.GetDropped<T>(index.x, index.y);
        }

        static public void SetDropped<T>(this IList2D<T> item, int x, int y, T value)
        {
            if (item.IsIndexValid(x, y))
                item[x, y] = value;
        }
        static public void SetDropped<T>(this IList2D<T> item, VectorI2 index, T value)
        {
            item.SetDropped<T>(index.x, index.y, value);
        }
    }
}