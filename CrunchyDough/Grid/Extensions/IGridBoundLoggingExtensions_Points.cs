using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridBoundLoggingExtensions_Points
    {
        static public int GetLeftBound<T>(this IGridBoundLogging<T> item)
        {
            return item.GetLowestX();
        }
        static public int GetBottomBound<T>(this IGridBoundLogging<T> item)
        {
            return item.GetLowestY();
        }
        static public int GetRightBound<T>(this IGridBoundLogging<T> item)
        {
            return item.GetHighestX();
        }
        static public int GetTopBound<T>(this IGridBoundLogging<T> item)
        {
            return item.GetHighestY();
        }

        static public int GetBoundWidth<T>(this IGridBoundLogging<T> item)
        {
            return item.GetRightBound() - item.GetLeftBound();
        }
        static public int GetBoundHeight<T>(this IGridBoundLogging<T> item)
        {
            return item.GetTopBound() - item.GetBottomBound();
        }

        static public VectorI2 GetLowerLeftBound<T>(this IGridBoundLogging<T> item)
        {
            return new VectorI2(item.GetLeftBound(), item.GetBottomBound());
        }
        static public VectorI2 GetLowerRightBound<T>(this IGridBoundLogging<T> item)
        {
            return new VectorI2(item.GetRightBound(), item.GetBottomBound());
        }
        static public VectorI2 GetUpperLeftBound<T>(this IGridBoundLogging<T> item)
        {
            return new VectorI2(item.GetLeftBound(), item.GetTopBound());
        }
        static public VectorI2 GetUpperRightBound<T>(this IGridBoundLogging<T> item)
        {
            return new VectorI2(item.GetRightBound(), item.GetTopBound());
        }
    }
}