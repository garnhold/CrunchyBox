using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    using Noodle;
    using Bun;
    
    public abstract class Brush<T>
    {
        public abstract void Paint(Surface<T> surface, Ink<T> ink, VectorF2 point);
        public abstract float GetWidth();
    }
}