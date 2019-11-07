using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ConductorOrder_Wait : ConductorOrder
    {
        private TemporalDuration temporal_duration;

        public ConductorOrder_Wait(TemporalDuration d)
        {
            temporal_duration = d;

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
