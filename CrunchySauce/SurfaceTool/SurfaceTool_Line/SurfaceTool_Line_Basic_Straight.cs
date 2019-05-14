using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySauce
{
    public class SurfaceTool_Line_Basic_Straight<T> : SurfaceTool_Line_Basic<T>
    {
        private float spacing_in_brush_width_percent;

        static public readonly SurfaceTool_Line_Basic_Straight<T> REGULAR = new SurfaceTool_Line_Basic_Straight<T>(0.1f);

        protected override void MarkLineInternal(Surface<T> surface, Utensil<T> utensil, VectorF2 point1, VectorF2 point2)
        {
            float distance;
            float spacing = spacing_in_brush_width_percent * utensil.GetWidth();
            VectorF2 step = point1.GetDirection(point2, out distance) * spacing;

            VectorF2 point = point1;
            int number_steps = (int)(distance / spacing);
            
            utensil.Mark(surface, point);
            for (int i = 1; i < number_steps; i++)
            {
                point += step;
                utensil.Mark(surface, point);
            }
        }

        public SurfaceTool_Line_Basic_Straight(float s)
        {
            spacing_in_brush_width_percent = s;
        }
    }
}