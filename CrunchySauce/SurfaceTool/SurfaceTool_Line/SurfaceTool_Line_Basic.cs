using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySauce
{
    public abstract class SurfaceTool_Line_Basic<T> : SurfaceTool_Line<T>
    {
        protected abstract void MarkLineInternal(Surface<T> surface, Utensil<T> utensil, VectorF2 point1, VectorF2 point2);

        public override void MarkLines(Surface<T> surface, Utensil<T> utensil, IEnumerable<VectorF2> points)
        {
            points.ProcessConnections((p, c) => MarkLineInternal(surface, utensil, p, c));
        }
    }
}