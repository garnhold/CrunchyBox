using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public class AIMachineCondition_Always : AIMachineCondition
    {
        public override bool IsSatisfied()
        {
            return true;
        }
    }
}