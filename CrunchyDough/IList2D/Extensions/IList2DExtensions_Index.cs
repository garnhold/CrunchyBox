using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Index
    {
        static public bool IsIndexValid<T>(this IList2D<T> item, int x, int y)
        {
            if (x >= 0 && x < item.GetWidth())
            {
                if (y >= 0 && y < item.GetHeight())
                    return true;
            }

            return false;
        }
        static public bool IsIndexValid<T>(this IList2D<T> item, IList2DIndex index)
        {
            return item.IsIndexValid<T>(index.GetX(), index.GetY());
        }
    }
}