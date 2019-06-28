using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class GridExtensions_Scale
    {
        static public Grid<T> GetScaledToDimensions<T>(this Grid<T> item, int new_width, int new_height)
        {
            float new_to_old_width = (float)item.GetWidth() / (float)new_width;
            float new_to_old_height = (float)item.GetHeight() / (float)new_height;

            return new Grid<T>(new_width, new_height, delegate(int x, int y) {
                return item.GetData(
                    (int)(x * new_to_old_width),
                    (int)(y * new_to_old_height)
                );
            });
        }

        static public Grid<T> GetScaledByFactor<T>(this Grid<T> item, float width_scale, float height_scale)
        {
            return item.GetScaledToDimensions<T>((int)(item.GetWidth() * width_scale), (int)(item.GetHeight() * height_scale));
        }
        static public Grid<T> GetScaledByFactor<T>(this Grid<T> item, float scale)
        {
            return item.GetScaledByFactor<T>(scale, scale);
        }
    }
}