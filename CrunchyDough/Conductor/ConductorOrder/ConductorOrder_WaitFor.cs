using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ConductorOrder_WaitFor : ConductorOrder
    {
        private TemporalEvent temporal_event;

        public ConductorOrder_WaitFor(TemporalEvent e)
        {
            temporal_event = e;
        }

        public ConductorOrder_WaitFor(TemporalDuration d) : this(d.GetAsTemporalEvent()) { }

        public ConductorOrder_WaitFor(long d, TimeSource t) : this(new Timer(d, t)) { }
        public ConductorOrder_WaitFor(long d) : this(d, TimeSource_System.INSTANCE) { }

        public ConductorOrder_WaitFor(Duration d, TimeSource t) : this(new Timer(d, t)) { }
        public ConductorOrder_WaitFor(Duration d) : this(d, TimeSource_System.INSTANCE) { }

        public override void Start()
        {
            temporal_event.Start();
        }

        public override bool Fulfill()
        {
            if (temporal_event.IsTimeOver())
                return true;

            return false;
        }
    }
}
