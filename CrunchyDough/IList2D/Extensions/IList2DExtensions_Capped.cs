using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Capped
    {
        static public T GetCapped<T>(this IList2D<T> item, int x, int y)
        {
            return item.GetDropped<T>(x.BindIndex(item.GetWidth()), y.BindIndex(item.GetHeight()));
        }
        static public T GetCapped<T>(this IList2D<T> item, VectorI2 index)
        {
            return item.GetCapped<T>(index.x, index.y);
        }

        static public void SetCapped<T>(this IList2D<T> item, int x, int y, T value)
        {
            item.SetDropped<T>(x.BindIndex(item.GetWidth()), y.BindIndex(item.GetHeight()), value);
        }
        static public void SetCapped<T>(this IList2D<T> item, VectorI2 index, T value)
        {
            item.SetCapped<T>(index.x, index.y, value);
        }
    }
}