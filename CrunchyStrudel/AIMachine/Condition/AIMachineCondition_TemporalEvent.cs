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
        private TemporalEvent timer;
        private bool restart_on_resume;

        public AIMachineCondition_TemporalEvent(TemporalEvent t, bool ror)
        {
            timer = t;
            restart_on_resume = ror;
        }

        public override void Resume()
        {
            if (restart_on_resume)
                timer.Restart();
            else
                timer.Start();
        }

        public override void Suspend()
        {
            timer.Pause();
        }

        public override bool IsSatisfied()
        {
            return timer.IsTimeOver();
        }
    }
}