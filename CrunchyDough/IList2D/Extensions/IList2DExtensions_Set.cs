using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Set
    {
        static public bool SetDropped<T>(this IList2D<T> item, int x, int y, T value)
        {
            if (item.IsIndexValid(x, y))
            {
                item[x, y] = value;
                return true;
            }

            return false;
        }
        static public bool SetDropped<T>(this IList2D<T> item, IList2DIndex index, T value)
        {
            return item.SetDropped(index.GetX(), index.GetY(), value);
        }
    }
}