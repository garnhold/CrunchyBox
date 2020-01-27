using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    
    public class SurfaceTool_Fill<T> : SurfaceTool<T>
    {
        public void Fill(Surface<T> surface, Ink<T> ink)
        {
            foreach (VectorI2 point in surface.GetSurfacePoints())
                ink.Paint(surface, 1.0f, point);
        }
    }
}