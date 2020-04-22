using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Concurrent : ConductorOrder
    {
        private List<ConductorOrder> orders;

        protected override bool InitializeFulfill()
        {
            orders.Process(o => o.Reset());
            return true;
        }

        protected override void StartFulfill()
        {
            orders.Process(o => o.ResumeFulfill());
        }

        protected override void PauseFulfill()
        {
            orders.Process(o => o.SuspendFulfill());
        }

        protected override void CancelFulfill()
        {
            orders.Process(o => o.Reset());
        }

        protected override void FinishFulfill()
        {
            orders.Process(o => o.Prime());
        }

        protected override bool UpdateFulfill()
        {
            if (orders.ProcessAND(o => o.ContinueFulfill()))
                return true;

            return false;
        }

        public ConductorOrder_Concurrent(IEnumerable<ConductorOrder> o)
        {
            orders = o.ToList();
        }

        public ConductorOrder_Concurrent(params ConductorOrder[] o) : this((IEnumerable<ConductorOrder>)o) { }
    }
}
