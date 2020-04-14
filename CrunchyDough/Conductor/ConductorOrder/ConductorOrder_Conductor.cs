using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Conductor : ConductorOrder
    {
        private Conductor conductor;

        public ConductorOrder_Conductor(Conductor c)
        {
            conductor = c;
        }

        public override void InitializeFulfill()
        {
            conductor.Reset();
        }

        public override void StartFulfill()
        {
            conductor.Start();
        }

        public override void PauseFulfill()
        {
            conductor.Pause();
        }

        public override bool UpdateFulfill()
        {
            return conductor.UpdateFulfill();
        }
    }
}
