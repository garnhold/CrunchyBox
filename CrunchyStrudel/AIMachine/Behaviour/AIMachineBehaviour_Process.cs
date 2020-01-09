using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    using Bun;
    
    public class AIMachineBehaviour_Process : AIMachineBehaviour
    {
        private Process resume_process;
        private Process suspend_process;
        private Process update_process;

        public AIMachineBehaviour_Process(Process r, Process s, Process u)
        {
            resume_process = r;
            suspend_process = s;
            update_process = u;
        }

        public AIMachineBehaviour_Process(Process r, Process u) : this(r, null, u) { }
        public AIMachineBehaviour_Process(Process u) : this(null, u) { }

        public override void Resume()
        {
            resume_process.IfNotNull(p => p());
        }

        public override void Suspend()
        {
            suspend_process.IfNotNull(p => p());
        }

        public override void Update()
        {
            update_process();
        }
    }

    static public class AIMachineNodeExtensions_Initialize_Process
    {
        static public void Initialize(this AIMachineNode item, Process resume, Process suspend, Process update, IEnumerable<AIMachineTransition> transitions)
        {
            item.Initialize(new AIMachineBehaviour_Process(resume, suspend, update), transitions);
        }
        static public void Initialize(this AIMachineNode item, Process resume, Process suspend, Process update, params AIMachineTransition[] transitions)
        {
            item.Initialize(resume, suspend, update, (IEnumerable<AIMachineTransition>)transitions);
        }

        static public void Initialize(this AIMachineNode item, Process resume, Process update, IEnumerable<AIMachineTransition> transitions)
        {
            item.Initialize(new AIMachineBehaviour_Process(resume, update), transitions);
        }
        static public void Initialize(this AIMachineNode item, Process resume, Process update, params AIMachineTransition[] transitions)
        {
            item.Initialize(resume, update, (IEnumerable<AIMachineTransition>)transitions);
        }

        static public void Initialize(this AIMachineNode item, Process update, IEnumerable<AIMachineTransition> transitions)
        {
            item.Initialize(new AIMachineBehaviour_Process(update), transitions);
        }
        static public void Initialize(this AIMachineNode item, Process update, params AIMachineTransition[] transitions)
        {
            item.Initialize(update, (IEnumerable<AIMachineTransition>)transitions);
        }
    }
}