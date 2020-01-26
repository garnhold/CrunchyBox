using System;

namespace Crunchy.Sauce
{
    using Dough;
    
    static public class VectorF2Extensions_SurfacePoint
    {
        static public SurfacePoint GetSurfacePoint(this VectorF2 item)
        {
            return new SurfacePoint((int)item.x, (int)item.y);
        }
    }
}