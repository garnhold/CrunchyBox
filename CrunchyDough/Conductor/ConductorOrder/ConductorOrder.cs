using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class ConductorOrder
    {
        public virtual void InitializeFulfill() { }
        public virtual void StartFulfill() { }
        public virtual void PauseFulfill() { }

        public abstract bool UpdateFulfill();
    }
}
