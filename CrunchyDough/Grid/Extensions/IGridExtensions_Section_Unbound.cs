using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Section_Unbound
    {
        static public IGrid<T> UnboundSubSection<T>(this IGrid<T> item, int x1, int y1, int x2, int y2, T default_value = default(T))
        {
            if (item != null)
            {
                return new IGridTransform<T>(
                    x2 - x1,
                    y2 - y1,
                    (x, y) => item.Get(x, y, default_value),
                    (x, y, v) => item.SetDropped(x, y, v)
                );
            }

            return Empty.IGrid<T>();
        }
        static public IGrid<T> UnboundSubSection<T>(this IGrid<T> item, VectorI2 lower, VectorI2 upper, T default_value = default(T))
        {
            return item.UnboundSubSection(lower.x, lower.y, upper.x, upper.y, default_value);
        }

        static public IGrid<T> UnboundSubArea<T>(this IGrid<T> item, int x, int y, int width_radius, int height_radius)
        {
            return item.UnboundSubSection<T>(x - width_radius, y - height_radius, x + width_radius, y + height_radius);
        }
        static public IGrid<T> UnboundSubArea<T>(this IGrid<T> item, VectorI2 center, VectorI2 radius)
        {
            return item.UnboundSubArea<T>(center.x, center.y, radius.x, radius.y);
        }

        static public IGrid<T> UnboundSubArea<T>(this IGrid<T> item, int x, int y, int radius)
        {
            return item.UnboundSubArea<T>(x, y, radius, radius);
        }
        static public IGrid<T> UnboundSubArea<T>(this IGrid<T> item, VectorI2 center, int radius)
        {
            return item.UnboundSubArea<T>(center.x, center.y, radius);
        }

        static public IGrid<T> UnboundSub<T>(this IGrid<T> item, int x, int y, int width, int height, T default_value = default(T))
        {
            return item.UnboundSubSection<T>(x, y, x + width, y + height, default_value);
        }
        static public IGrid<T> UnboundSub<T>(this IGrid<T> item, VectorI2 index, VectorI2 size, T default_value = default(T))
        {
            return item.UnboundSubSection<T>(index, index + size);
        }
    }
}