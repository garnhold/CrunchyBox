using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    using Bun;
    
    public class AIMachineCondition_Always : AIMachineCondition
    {
        public override bool IsSatisfied()
        {
            return true;
        }
    }
}