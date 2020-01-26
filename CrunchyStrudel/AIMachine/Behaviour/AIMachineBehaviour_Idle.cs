using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    
    public class AIMachineBehaviour_Idle : AIMachineBehaviour
    {
        public override void Update() { }
    }

    static public class AIMachineNodeExtensions_Initialize_Idle
    {
        static public void InitializeIdle(this AIMachineNode item, IEnumerable<AIMachineTransition> transitions)
        {
            item.Initialize(new AIMachineBehaviour_Idle(), transitions);
        }
        static public void InitializeIdle(this AIMachineNode item, params AIMachineTransition[] transitions)
        {
            item.InitializeIdle((IEnumerable<AIMachineTransition>)transitions);
        }
    }
}