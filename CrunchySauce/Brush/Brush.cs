using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySauce
{
    public abstract class Brush<T>
    {
        public abstract void Paint(Surface<T> surface, Ink<T> ink, VectorF2 point);
        public abstract float GetWidth();
    }
}