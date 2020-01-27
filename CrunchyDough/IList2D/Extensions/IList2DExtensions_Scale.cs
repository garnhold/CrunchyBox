
using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Scale
    {
        static public IList2D<T> ScaleToDimensions<T>(this IList2D<T> item, int new_width, int new_height)
        {
            float new_to_old_width = (float)item.GetWidth() / (float)new_width;
            float new_to_old_height = (float)item.GetHeight() / (float)new_height;

            return new IList2DTransform<T>(
                () => new_width,
                () => new_height,
                (x, y) => item[(int)(x * new_to_old_width), (int)(y * new_to_old_height)]
            );
        }

        static public IList2D<T> ScaleByFactor<T>(this IList2D<T> item, float width_scale, float height_scale)
        {
            return item.ScaleToDimensions<T>((int)(item.GetWidth() * width_scale), (int)(item.GetHeight() * height_scale));
        }
        static public IList2D<T> GetScaledByFactor<T>(this IList2D<T> item, float scale)
        {
            return item.ScaleByFactor<T>(scale, scale);
        }
    }
}