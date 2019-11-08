using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class ConductorOrder
    {
        public virtual void Start() { }

        public abstract bool Fulfill();
    }
}
