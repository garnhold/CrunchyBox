using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridBoundLoggingExtensions_Size
    {
        static public int GetBoundWidth<T>(this IGridBoundLogging<T> item)
        {
            return item.GetRightBound() - item.GetLeftBound();
        }
        static public int GetBoundHeight<T>(this IGridBoundLogging<T> item)
        {
            return item.GetTopBound() - item.GetBottomBound();
        }

        static public VectorI2 GetBoundSize<T>(this IGridBoundLogging<T> item)
        {
            return new VectorI2(item.GetBoundWidth(), item.GetBoundHeight());
        }

        static public RectI2 GetBoundRect<T>(this IGridBoundLogging<T> item)
        {
            return RectI2Extensions.CreateLowerLeftRectI2(item.GetLowerLeftBound(), item.GetBoundSize());
        }
    }
}