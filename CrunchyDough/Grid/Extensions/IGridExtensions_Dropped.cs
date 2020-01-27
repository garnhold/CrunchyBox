using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Dropped
    {
        static public T GetDropped<T>(this IGrid<T> item, int x, int y)
        {
            if (item.IsIndexValid(x, y))
                return item[x, y];

            return default(T);
        }
        static public T GetDropped<T>(this IGrid<T> item, VectorI2 index)
        {
            return item.GetDropped<T>(index.x, index.y);
        }

        static public void SetDropped<T>(this IGrid<T> item, int x, int y, T value)
        {
            if (item.IsIndexValid(x, y))
                item[x, y] = value;
        }
        static public void SetDropped<T>(this IGrid<T> item, VectorI2 index, T value)
        {
            item.SetDropped<T>(index.x, index.y, value);
        }
    }
}