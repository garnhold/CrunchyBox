using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    using Bun;
    
    public class SurfaceTool_Fill<T> : SurfaceTool<T>
    {
        public void Fill(Surface<T> surface, Ink<T> ink)
        {
            foreach (SurfacePoint point in surface.GetSurfacePoints())
                ink.Paint(surface, 1.0f, point.GetVectorF2());
        }
    }
}