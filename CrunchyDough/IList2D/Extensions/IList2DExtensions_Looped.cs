using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Looped
    {
        static public T GetLooped<T>(this IList2D<T> item, int x, int y)
        {
            return item.GetDropped<T>(x.GetLooped(item.GetWidth()), y.GetLooped(item.GetHeight()));
        }
        static public T GetLooped<T>(this IList2D<T> item, VectorI2 index)
        {
            return item.GetLooped<T>(index.x, index.y);
        }

        static public void SetLooped<T>(this IList2D<T> item, int x, int y, T value)
        {
            item.SetDropped<T>(x.GetLooped(item.GetWidth()), y.GetLooped(item.GetHeight()), value);
        }
        static public void SetLooped<T>(this IList2D<T> item, VectorI2 index, T value)
        {
            item.SetLooped<T>(index.x, index.y, value);
        }
    }
}