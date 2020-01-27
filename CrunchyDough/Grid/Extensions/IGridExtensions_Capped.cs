using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Capped
    {
        static public T GetCapped<T>(this IGrid<T> item, int x, int y)
        {
            return item.GetDropped<T>(x.BindIndex(item.GetWidth()), y.BindIndex(item.GetHeight()));
        }
        static public T GetCapped<T>(this IGrid<T> item, VectorI2 index)
        {
            return item.GetCapped<T>(index.x, index.y);
        }

        static public void SetCapped<T>(this IGrid<T> item, int x, int y, T value)
        {
            item.SetDropped<T>(x.BindIndex(item.GetWidth()), y.BindIndex(item.GetHeight()), value);
        }
        static public void SetCapped<T>(this IGrid<T> item, VectorI2 index, T value)
        {
            item.SetCapped<T>(index.x, index.y, value);
        }
    }
}