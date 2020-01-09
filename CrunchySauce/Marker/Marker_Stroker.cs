using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    using Noodle;
    using Bun;
    
    public class Marker_Stroker<T> : Marker<T>
    {
        private VectorF2 current_point;
        private SurfaceTool_Line<T> line_tool;

        public Marker_Stroker(Surface<T> s, Utensil<T> u, VectorF2 p, SurfaceTool_Line<T> l) : base(u, s)
        {
            current_point = p;
            line_tool = l;
        }

        public void Restart(VectorF2 point)
        {
            current_point = point;
        }

        public void StrokeTo(VectorF2 point)
        {
            line_tool.MarkLines(GetSurface(), GetUtensil(), current_point, point);
            current_point = point;
        }

        public VectorF2 Stroke(VectorF2 amount)
        {
            StrokeTo(current_point + amount);
            return current_point;
        }

        public VectorF2 GetCurrentPoint()
        {
            return current_point;
        }
    }
}