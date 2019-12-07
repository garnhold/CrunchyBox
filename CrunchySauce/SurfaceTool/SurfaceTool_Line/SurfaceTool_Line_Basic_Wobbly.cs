using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    using Noodle;
    using Bun;
    
    public class SurfaceTool_Line_Basic_Wobbly<T> : SurfaceTool_Line_Basic<T>
    {
        private float angle_delta;
        private float stroke_length;
        private SurfaceTool_Line<T> internal_tool_line;

        protected override void MarkLineInternal(Surface<T> surface, Utensil<T> utensil, VectorF2 point1, VectorF2 point2)
        {
            VectorF2 diff = point2 - point1;
            VectorF2 step_diff = diff;

            Marker_Stroker<T> stroker = new Marker_Stroker<T>(surface, utensil, point1, internal_tool_line);
            while (diff.IsComplyingDirection(step_diff))
            {
                VectorF2 point = stroker.Stroke(step_diff.GetJitteredDirectionAngleInRadians(angle_delta) * stroke_length);

                step_diff = point2 - point;
            }
        }

        public SurfaceTool_Line_Basic_Wobbly(float a, float s, SurfaceTool_Line<T> l)
        {
            angle_delta = a;
            stroke_length = s;
            internal_tool_line = l;
        }

        public SurfaceTool_Line_Basic_Wobbly(float a, float s) : this(a, s, SurfaceTool_Line_Basic_Straight<T>.REGULAR) { }
    }
}