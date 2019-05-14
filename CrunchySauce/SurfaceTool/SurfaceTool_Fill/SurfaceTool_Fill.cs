using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySauce
{
    public class SurfaceTool_Fill<T> : SurfaceTool<T>
    {
        public void Fill(Surface<T> surface, Ink<T> ink)
        {
            foreach (SurfacePoint point in surface.GetSurfacePoints())
                ink.Paint(surface, 1.0f, point.GetVectorF2());
        }
    }
}