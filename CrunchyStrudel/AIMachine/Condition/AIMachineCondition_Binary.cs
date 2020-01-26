using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    
    public abstract class AIMachineCondition_Binary : AIMachineCondition
    {
        private AIMachineCondition condition1;
        private AIMachineCondition condition2;

        protected abstract bool IsSatisfiedInternal(AIMachineCondition c1, AIMachineCondition c2);

        public AIMachineCondition_Binary(AIMachineCondition c1, AIMachineCondition c2)
        {
            condition1 = c1;
            condition2 = c2;
        }

        public override void Resume()
        {
            condition1.Resume();
            condition2.Resume();
        }

        public override void Suspend()
        {
            condition1.Suspend();
            condition2.Suspend();
        }

        public override bool IsSatisfied()
        {
            return IsSatisfiedInternal(condition1, condition2);
        }
    }
}