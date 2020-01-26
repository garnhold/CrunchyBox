using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    
    public class AIMachineTransition
    {
        private AIMachineNode node;
        private AIMachineCondition condition;

        public AIMachineTransition(AIMachineNode n, AIMachineCondition c)
        {
            node = n;
            condition = c;
        }

        public AIMachineTransition(AIMachineNode n, Process r, Process s, Operation<bool> p) : this(n, new AIMachineCondition_Predicate(r, s, p)) { }
        public AIMachineTransition(AIMachineNode n, Process r, Operation<bool> p) : this(n, new AIMachineCondition_Predicate(r, p)) { }
        public AIMachineTransition(AIMachineNode n, Operation<bool> p) : this(n, new AIMachineCondition_Predicate(p)) { }

        public AIMachineTransition(AIMachineNode n) : this(n, new AIMachineCondition_Always()) { }

        public AIMachineNode Update()
        {
            if (condition.IsSatisfied())
                return node;

            return null;
        }

        public void Resume()
        {
            condition.Resume();
        }

        public void Suspend()
        {
            condition.Suspend();
        }

        public AIMachineNode GetNode()
        {
            return node;
        }

        public AIMachineCondition GetCondition()
        {
            return condition;
        }
    }
}