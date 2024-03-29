using System;

namespace Crunchy.Sauce
{
    using Dough;
    using Noodle;
    
    public class Ink_Basic<T> : Ink<T>
    {
        private T pigment;
        private Mixer<T> pigment_mixer;

        private void PaintInternal(Surface<T> surface, int x, int y, float weight, Mixer<T> pigment_mixer)
        {
            surface.MixPigmentAt(x, y, pigment, weight, pigment_mixer);
        }

        public Ink_Basic(T p, Mixer<T> m)
        {
            pigment = p;
            pigment_mixer = m;
        }

        public override void Paint(Surface<T> surface, float weight, VectorF2 point)
        {
            if (weight > 0.0f)
            {
                int left = (int)point.x;
                int bottom = (int)point.y;

                float right_width = point.x - left;
                float left_width = 1.0f - right_width;

                float top_height = point.y - bottom;
                float bottom_height = 1.0f - top_height;

                int right = left + 1;
                int top = bottom + 1;

                float left_bottom_area = left_width * bottom_height;
                float right_bottom_area = right_width * bottom_height;

                float left_top_area = left_width * top_height;
                float right_top_area = right_width * top_height;

                if(left_bottom_area > 0.0f)
                    PaintInternal(surface, left, bottom, left_bottom_area * weight, pigment_mixer);

                if(right_bottom_area > 0.0f)
                    PaintInternal(surface, right, bottom, right_bottom_area * weight, pigment_mixer);

                if(left_top_area > 0.0f)
                    PaintInternal(surface, left, top, left_top_area * weight, pigment_mixer);

                if(right_top_area > 0.0f)
                    PaintInternal(surface, right, top, right_top_area * weight, pigment_mixer);
            }
        }
    }
}