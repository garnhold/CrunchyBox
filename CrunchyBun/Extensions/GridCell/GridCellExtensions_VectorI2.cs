using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class GridCellExtensions_VectorI2
    {
        static public VectorI2 GetPointI2<T>(this GridCell<T> item)
        {
            return new VectorI2(item.GetX(), item.GetY());
        }
    }
}