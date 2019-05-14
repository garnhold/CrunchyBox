using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySauce
{
    static public class GridCellExtensions_SurfacePoint
    {
        static public SurfacePoint GetSurfacePoint<T>(this GridCell<T> item)
        {
            return new SurfacePoint(item.GetX(), item.GetY());
        }
    }
}