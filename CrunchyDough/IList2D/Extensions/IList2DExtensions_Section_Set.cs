using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Section_Set
    {
        static public void SetSection<T>(this IList2D<T> item, int x, int y, IList2D<T> value)
        {
            value
                .BoundSub(0, 0, item.GetWidth() - x, item.GetHeight() - y)
                .ProcessWithIndexs((sx, sy, v) => item[x + sx, y + sy] = v);
        }
        static public void SetSection<T>(this IList2D<T> item, IList2DIndex position, IList2D<T> value)
        {
            item.SetSection<T>(position.GetX(), position.GetY(), value);
        }
    }
}