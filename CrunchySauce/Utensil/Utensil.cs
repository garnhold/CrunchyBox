using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    using Noodle;
    using Bun;
    
    public abstract class Utensil<T>
    {
        public abstract void Mark(Surface<T> surface, VectorF2 point);
        public abstract float GetWidth();
    }
}