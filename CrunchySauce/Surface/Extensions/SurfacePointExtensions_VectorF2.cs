using System;

namespace Crunchy.Sauce
{
    using Bun;
    
    static public class SurfacePointExtensions_VectorF2
    {
        static public VectorF2 GetVectorF2(this SurfacePoint item)
        {
            return new VectorF2(item.x, item.y);
        }
    }
}