using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Section_Bound
    {
        static public IGrid<T> BoundSubSection<T>(this IGrid<T> item, int x1, int y1, int x2, int y2)
        {
            if (item != null)
            {
                x1 = x1.BindBetween(0, item.GetWidth());
                x2 = x2.BindBetween(0, item.GetWidth());

                y1 = y1.BindBetween(0, item.GetHeight());
                y2 = y2.BindBetween(0, item.GetHeight());

                if (x1 == 0 && y1 == 0 && x2 == item.GetWidth() && y2 == item.GetHeight())
                    return item;

                return new IGridTransform<T>(
                    x2 - x1,
                    y2 - y1,
                    (x, y) => item[x1 + x, y1 + y],
                    (x, y, v) => item[x1 + x, y1 + y] = v
                );
            }

            return Empty.IGrid<T>();
        }
        static public IGrid<T> BoundSubSection<T>(this IGrid<T> item, VectorI2 lower, VectorI2 upper)
        {
            return item.BoundSubSection(lower.x, lower.y, upper.x, upper.y);
        }

        static public IGrid<T> BoundSubArea<T>(this IGrid<T> item, int x, int y, int width_radius, int height_radius)
        {
            return item.BoundSubSection<T>(x - width_radius, y - height_radius, x + width_radius, y + height_radius);
        }
        static public IGrid<T> BoundSubArea<T>(this IGrid<T> item, VectorI2 center, VectorI2 radius)
        {
            return item.BoundSubArea<T>(center.x, center.y, radius.x, radius.y);
        }

        static public IGrid<T> BoundSubArea<T>(this IGrid<T> item, int x, int y, int radius)
        {
            return item.BoundSubArea<T>(x, y, radius, radius);
        }
        static public IGrid<T> BoundSubArea<T>(this IGrid<T> item, VectorI2 center, int radius)
        {
            return item.BoundSubArea<T>(center.x, center.y, radius);
        }

        static public IGrid<T> BoundSub<T>(this IGrid<T> item, int x, int y, int width, int height)
        {
            return item.BoundSubSection<T>(x, y, x + width, y + height);
        }
        static public IGrid<T> BoundSub<T>(this IGrid<T> item, VectorI2 index, VectorI2 size)
        {
            return item.BoundSubSection<T>(index, index + size);
        }
    }
}