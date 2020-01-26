using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    
    public class AIMorpherNode_Process : AIMorpherNode
    {
        private Operation<float> upkeep_operation;

        private Process resume_process;
        private Process suspend_process;
        private Process<float> update_process;

        protected override float UpkeepInternal()
        {
            return upkeep_operation();
        }

        protected override void ResumeInternal()
        {
            resume_process.IfNotNull(p => p());
        }

        protected override void SuspendInternal()
        {
            suspend_process.IfNotNull(p => p());
        }

        protected override void UpdateInternal(float intrest)
        {
            update_process.IfNotNull(p => p(intrest));
        }

        public AIMorpherNode_Process(Operation<float> uo, Process r, Process s, Process<float> u)
        {
            upkeep_operation = uo;

            resume_process = r;
            suspend_process = s;
            update_process = u;
        }

        public AIMorpherNode_Process(Operation<float> uo, Process r, Process<float> u) : this(uo, r, null, u) { }
        public AIMorpherNode_Process(Operation<float> uo, Process<float> u) : this(uo, null, u) { }
    }
}