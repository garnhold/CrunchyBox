using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class GridCellExtensions_VectorI2
    {
        static public VectorI2 GetPointI2<T>(this GridCell<T> item)
        {
            return new VectorI2(item.GetX(), item.GetY());
        }
    }
}