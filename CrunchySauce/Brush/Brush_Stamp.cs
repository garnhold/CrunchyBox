using System;

namespace Crunchy.Sauce
{
    using Dough;
    
    public class Brush_Stamp<T> : Brush<T>
    {
        private Stamp<float> stamp;

        public Brush_Stamp(Stamp<float> s)
        {
            stamp = s;
        }

        public override void Paint(Surface<T> surface, Ink<T> ink, VectorF2 point)
        {
            stamp.Press(point, delegate(float w, VectorF2 p) {
                ink.Paint(surface, w, p);
            });
        }

        public override float GetWidth()
        {
            return stamp.GetDimensions().GetMaxComponent();
        }
    }
}