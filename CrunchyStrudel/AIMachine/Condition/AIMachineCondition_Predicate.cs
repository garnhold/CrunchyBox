using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public class AIMachineCondition_Predicate : AIMachineCondition
    {
        private Process resume_process;
        private Process suspend_process;

        private Operation<bool> predicate;

        public AIMachineCondition_Predicate(Process r, Process s, Operation<bool> p)
        {
            resume_process = r;
            suspend_process = s;

            predicate = p;
        }

        public AIMachineCondition_Predicate(Process r, Operation<bool> p) : this(r, null, p) { }
        public AIMachineCondition_Predicate(Operation<bool> p) : this(null, p) { }

        public override void Resume()
        {
            resume_process.IfNotNull(p => p());
        }

        public override void Suspend()
        {
            suspend_process.IfNotNull(p => p());
        }

        public override bool IsSatisfied()
        {
            return predicate();
        }
    }
}