using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public abstract class AIMachineCondition
    {
        static public AIMachineCondition operator &(AIMachineCondition c1, AIMachineCondition c2)
        {
            return new AIMachineCondition_Binary_And(c1, c2);
        }

        static public AIMachineCondition operator |(AIMachineCondition c1, AIMachineCondition c2)
        {
            return new AIMachineCondition_Binary_Or(c1, c2);
        }

        public abstract bool IsSatisfied();

        public virtual void Resume() { }
        public virtual void Suspend() { }
    }
}