
using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Scale
    {
        static public IGrid<T> ConvertToNewDimensionsScaled<T>(this IGrid<T> item, int new_width, int new_height)
        {
            float new_to_old_width = (float)item.GetWidth() / (float)new_width;
            float new_to_old_height = (float)item.GetHeight() / (float)new_height;

            return new IGridTransform<T>(new_width, new_height,
                (x, y) => item[(int)(x * new_to_old_width), (int)(y * new_to_old_height)]
            );
        }

        static public IGrid<T> ConvertToDimensionsScaledByFactor<T>(this IGrid<T> item, float width_scale, float height_scale)
        {
            return item.ConvertToNewDimensionsScaled<T>((int)(item.GetWidth() * width_scale), (int)(item.GetHeight() * height_scale));
        }
        static public IGrid<T> ConvertToDimensionsScaledByFactor<T>(this IGrid<T> item, float scale)
        {
            return item.ConvertToDimensionsScaledByFactor<T>(scale, scale);
        }
    }
}