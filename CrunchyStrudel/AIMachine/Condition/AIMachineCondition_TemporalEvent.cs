using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public class AIMachineCondition_TemporalEvent : AIMachineCondition
    {
        private TemporalEvent temporal_event;
        private bool restart_on_resume;

        public AIMachineCondition_TemporalEvent(TemporalEvent t, bool ror)
        {
            temporal_event = t;
            restart_on_resume = ror;
        }

        public AIMachineCondition_TemporalEvent(TemporalDuration d, bool ror) : this(d.GetAsTemporalEvent(), ror) { }

        public AIMachineCondition_TemporalEvent(long d, TimeSource t, bool ror) : this(new Timer(d, t), ror) { }
        public AIMachineCondition_TemporalEvent(long d, bool ror) : this(d, TimeSource_System.INSTANCE, ror) { }

        public AIMachineCondition_TemporalEvent(Duration d, TimeSource t, bool ror) : this(new Timer(d, t), ror) { }
        public AIMachineCondition_TemporalEvent(Duration d, bool ror) : this(d, TimeSource_System.INSTANCE, ror) { }

        public override void Resume()
        {
            if (restart_on_resume)
                temporal_event.Restart();
            else
                temporal_event.Start();
        }

        public override void Suspend()
        {
            temporal_event.Pause();
        }

        public override bool IsSatisfied()
        {
            return temporal_event.IsTimeOver();
        }
    }
}