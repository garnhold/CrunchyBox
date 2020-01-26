using System;

namespace Crunchy.Sauce
{
    using Dough;
    using Noodle;
    
    public abstract class Ink<T>
    {
        public abstract void Paint(Surface<T> surface, float weight, VectorF2 point);
    }
}