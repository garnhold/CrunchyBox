using System;

namespace Crunchy.Sauce
{
    using Dough;
    
    public class Brush_Pixel<T> : Brush<T>
    {
        static public readonly Brush_Pixel<T> INSTANCE = new Brush_Pixel<T>();

        public override void Paint(Surface<T> surface, Ink<T> ink, VectorF2 point)
        {
            ink.Paint(surface, 1.0f, point);
        }

        public override float GetWidth()
        {
            return 0.95f;
        }
    }
}