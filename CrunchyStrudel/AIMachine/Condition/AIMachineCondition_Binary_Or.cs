using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    
    public class AIMachineCondition_Binary_Or : AIMachineCondition_Binary
    {
        protected override bool IsSatisfiedInternal(AIMachineCondition c1, AIMachineCondition c2)
        {
            if (c1.IsSatisfied() || c2.IsSatisfied())
                return true;

            return false;
        }

        public AIMachineCondition_Binary_Or(AIMachineCondition c1, AIMachineCondition c2) : base(c1, c2)
        {
        }
    }
}