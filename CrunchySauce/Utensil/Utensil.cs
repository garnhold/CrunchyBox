using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySauce
{
    public abstract class Utensil<T>
    {
        public abstract void Mark(Surface<T> surface, VectorF2 point);
        public abstract float GetWidth();
    }
}