using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public abstract class AIMachineBehaviour
    {
        public virtual void Resume() { }
        public virtual void Suspend() { }

        public abstract void Update();
    }
}