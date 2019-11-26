using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public class AIMachineCondition_SustainedPredicate : AIMachineCondition
    {
        private Process resume_process;
        private Process suspend_process;

        private Operation<bool> predicate;

        private TemporalEvent temporal_event;

        public AIMachineCondition_SustainedPredicate(Process r, Process s, Operation<bool> p, TemporalEvent t)
        {
            resume_process = r;
            suspend_process = s;

            predicate = p;

            temporal_event = t;
        }

        public AIMachineCondition_SustainedPredicate(Process r, Operation<bool> p, TemporalEvent t) : this(r, null, p, t) { }
        public AIMachineCondition_SustainedPredicate(Operation<bool> p, TemporalEvent t) : this(null, p, t) { }

        public AIMachineCondition_SustainedPredicate(Process r, Process s, Operation<bool> p, TemporalDuration d) : this(r, s, p, d.GetAsTemporalEvent()) { }
        public AIMachineCondition_SustainedPredicate(Process r, Operation<bool> p, TemporalDuration d) : this(r, null, p, d) { }
        public AIMachineCondition_SustainedPredicate(Operation<bool> p, TemporalDuration d) : this(null, p, d) { }

        public override void Resume()
        {
            resume_process.IfNotNull(p => p());

            temporal_event.StopClear();
        }

        public override void Suspend()
        {
            suspend_process.IfNotNull(p => p());

            temporal_event.StopClear();
        }

        public override bool IsSatisfied()
        {
            if (predicate())
                temporal_event.Start();
            else
                temporal_event.StopClear();

            if (temporal_event.IsTimeOver())
                return true;

            return false;
        }
    }
}