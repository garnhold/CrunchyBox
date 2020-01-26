using System;

namespace Crunchy.Dough
{    
    static public class GridExtensions_VectorI2
    {
        static public VectorI2 GetDimensionsI2<T>(this Grid<T> item)
        {
            return new VectorI2(item.GetWidth(), item.GetHeight());
        }

        static public VectorI2 GetExtentsI2<T>(this Grid<T> item)
        {
            return item.GetDimensionsI2() / 2;
        }
    }
}