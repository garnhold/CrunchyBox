using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class GridCellExtensions_VectorF2
    {
        static public VectorF2 GetPointF2<T>(this GridCell<T> item)
        {
            return new VectorF2(item.GetX(), item.GetY());
        }
    }
}