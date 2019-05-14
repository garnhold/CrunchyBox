using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySauce
{
    public class SurfaceTool_Line_Basic_Scratch<T> : SurfaceTool_Line_Basic<T>
    {
        private RandFloatBox margin_rand;
        private RandFloatBox length_rand;

        private float scratch_radius;
        private float scratch_internode;

        private SurfaceTool_Line<T> internal_line_tool;

        protected override void MarkLineInternal(Surface<T> texture, Utensil<T> utensil, VectorF2 point1, VectorF2 point2)
        {
            float start = 0.0f;
            float end = point1.GetDistanceTo(point2);

            for (float position = start; position < end; position += scratch_internode)
            {
                float pos1 = start - margin_rand.Get();
                float pos2 = (position + length_rand.Get()).BindBelow(end) + margin_rand.Get();

                internal_line_tool.MarkLines(texture, utensil, 
                    RandVectorF2.GetNearLinePoint(point1, point2, pos1, scratch_radius),
                    RandVectorF2.GetNearLinePoint(point1, point2, pos2, scratch_radius)
                );
            }
        }

        public SurfaceTool_Line_Basic_Scratch(float lm, float hm, float ll, float hl, float sr, float si, SurfaceTool_Line<T> l)
        {
            margin_rand = new RandFloatBox_Between(lm, hm);
            length_rand = new RandFloatBox_Between(ll, hl);

            scratch_radius = sr;
            scratch_internode = si;

            internal_line_tool = l;
        }

        public SurfaceTool_Line_Basic_Scratch(float lm, float hm, float ll, float hl, float sr, float si) : this(lm, hm, ll, hl, sr, si, SurfaceTool_Line_Basic_Straight<T>.REGULAR) { }
    }
}