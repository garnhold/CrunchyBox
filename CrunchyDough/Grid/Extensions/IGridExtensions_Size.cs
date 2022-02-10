using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Size
    {
        static public VectorI2 GetSize<T>(this IGrid<T> item)
        {
            return new VectorI2(item.GetWidth(), item.GetHeight());
        }

        static public RectI2 GetRect<T>(this IGrid<T> item)
        {
            return RectI2Extensions.CreateLowerLeftRectI2(VectorI2.ZERO, item.GetSize());
        }
    }
}