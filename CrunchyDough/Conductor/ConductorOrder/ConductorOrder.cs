using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class ConductorOrder
    {
        public virtual void Start() { }

        public abstract bool Fulfill();
    }
}
