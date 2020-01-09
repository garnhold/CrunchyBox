using System;

namespace Crunchy.Sauce
{
    using Dough;
    using Bun;
    
    static public class GridCellExtensions_SurfacePoint
    {
        static public SurfacePoint GetSurfacePoint<T>(this GridCell<T> item)
        {
            return new SurfacePoint(item.GetX(), item.GetY());
        }
    }
}