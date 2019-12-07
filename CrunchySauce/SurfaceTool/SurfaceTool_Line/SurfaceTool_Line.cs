using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    using Bun;
    
    public abstract class SurfaceTool_Line<T> : SurfaceTool<T>
    {
        public abstract void MarkLines(Surface<T> surface, Utensil<T> utensil, IEnumerable<VectorF2> points);
        public void MarkLines(Surface<T> surface, Utensil<T> utensil, params VectorF2[] points)
        {
            MarkLines(surface, utensil, (IEnumerable<VectorF2>)points);
        }

        public void MarkLoop(Surface<T> surface, Utensil<T> utensil, IEnumerable<VectorF2> points)
        {
            MarkLines(surface, utensil, points.CloseLoop());
        }
        public void MarkLoop(Surface<T> surface, Utensil<T> utensil, params VectorF2[] points)
        {
            MarkLoop(surface, utensil, (IEnumerable<VectorF2>)points);
        }
    }
}