using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Index
    {
        static public bool IsIndexValid<T>(this IGrid<T> item, int x, int y)
        {
            if (x >= 0 && x < item.GetWidth())
            {
                if (y >= 0 && y < item.GetHeight())
                    return true;
            }

            return false;
        }
        static public bool IsIndexValid<T>(this IGrid<T> item, VectorI2 index)
        {
            return item.IsIndexValid<T>(index.x, index.y);
        }
    }
}