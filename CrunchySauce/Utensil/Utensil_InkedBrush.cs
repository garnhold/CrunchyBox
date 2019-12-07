using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    using Noodle;
    using Bun;
    
    public class Utensil_InkedBrush<T> : Utensil<T>
    {
        private Ink<T> ink;
        private Brush<T> brush;

        public Utensil_InkedBrush(Ink<T> i, Brush<T> b)
        {
            ink = i;
            brush = b;
        }

        public override void Mark(Surface<T> surface, VectorF2 point)
        {
            brush.Paint(surface, ink, point);
        }

        public override float GetWidth()
        {
            return brush.GetWidth();
        }
    }
}