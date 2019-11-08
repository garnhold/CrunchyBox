using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ConductorOrder_WaitFor : ConductorOrder
    {
        private TemporalDuration temporal_duration;

        public ConductorOrder_WaitFor(TemporalDuration d)
        {
            temporal_duration = d;
        }

        public ConductorOrder_WaitFor(long d, TimeSource t) : this(new Timer(d, t)) { }
        public ConductorOrder_WaitFor(long d) : this(d, TimeSource_System.INSTANCE) { }

        public ConductorOrder_WaitFor(Duration d, TimeSource t) : this(new Timer(d, t)) { }
        public ConductorOrder_WaitFor(Duration d) : this(d, TimeSource_System.INSTANCE) { }

        public override void Start()
        {
            temporal_duration.Start();
        }

        public override bool Fulfill()
        {
            if (temporal_duration.IsTimeOver())
                return true;

            return false;
        }
    }
}
