using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class GridExtensions_VectorF2
    {
        static public VectorF2 GetDimensionsF2<T>(this Grid<T> item)
        {
            return new VectorF2(item.GetWidth(), item.GetHeight());
        }

        static public VectorF2 GetExtentsF2<T>(this Grid<T> item)
        {
            return item.GetDimensionsF2() * 0.5f;
        }
    }
}