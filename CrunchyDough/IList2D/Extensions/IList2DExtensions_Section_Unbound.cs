using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Section_Unbound
    {
        static public IList2D<T> UnboundSubSection<T>(this IList2D<T> item, int x1, int y1, int x2, int y2, T default_value = default(T))
        {
            if (item != null)
            {
                return new IList2DTransform<T>(
                    x2 - x1,
                    y2 - y1,
                    (x, y) => item.Get(x, y, default_value),
                    (x, y, v) => item.SetDropped(x, y, v)
                );
            }

            return Empty.IList2D<T>();
        }
        static public IList2D<T> UnboundSubSection<T>(this IList2D<T> item, VectorI2 lower, VectorI2 upper, T default_value = default(T))
        {
            return item.UnboundSubSection(lower.x, lower.y, upper.x, upper.y, default_value);
        }

        static public IList2D<T> UnboundSub<T>(this IList2D<T> item, int x, int y, int width, int height, T default_value = default(T))
        {
            return item.UnboundSubSection<T>(x, y, x + width, y + height, default_value);
        }
        static public IList2D<T> UnboundSub<T>(this IList2D<T> item, VectorI2 index, VectorI2 size, T default_value = default(T))
        {
            return item.UnboundSubSection<T>(index, index + size);
        }
    }
}