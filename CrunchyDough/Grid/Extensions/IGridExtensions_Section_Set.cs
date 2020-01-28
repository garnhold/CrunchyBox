using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Section_Set
    {
        static public void SetSection<T>(this IGrid<T> item, int x, int y, IGrid<T> value)
        {
            value.BoundSub(0, 0, item.GetWidth() - x, item.GetHeight() - y)
                .ProcessWithIndexs((sx, sy, v) => item[x + sx, y + sy] = v);
        }
        static public void SetSection<T>(this IGrid<T> item, VectorI2 index, IGrid<T> value)
        {
            item.SetSection<T>(index.x, index.y, value);
        }
    }
}