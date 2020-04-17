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

        public ConductorOrder_Conductor(ConductorScore s) : this(new Conductor(s)) { }

        public ConductorOrder_Conductor(IEnumerable<ConductorOrder> e) : this(new ConductorScore(e)) { }
        public ConductorOrder_Conductor(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }
        public ConductorOrder_Conductor(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

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
