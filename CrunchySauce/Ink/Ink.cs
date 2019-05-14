using System;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySauce
{
    public abstract class Ink<T>
    {
        public abstract void Paint(Surface<T> surface, float weight, VectorF2 point);
    }
}