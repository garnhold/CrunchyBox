using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    using Bun;
    
    public abstract class AIMachineBehaviour
    {
        public virtual void Resume() { }
        public virtual void Suspend() { }

        public abstract void Update();
    }
}