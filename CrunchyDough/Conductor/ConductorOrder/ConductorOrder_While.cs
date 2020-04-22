using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_While : ConductorOrder
    {
        private ConductorOrder order;
        private Operation<bool> operation;

        protected override bool InitializeFulfill()
        {
            order.Reset();
            return true;
        }

        protected override void StartFulfill()
        {
            order.ResumeFulfill();
        }

        protected override void PauseFulfill()
        {
            order.SuspendFulfill();
        }

        protected override void CancelFulfill()
        {
            order.Reset();
        }

        protected override void FinishFulfill()
        {
            order.Prime();
        }

        protected override bool UpdateFulfill()
        {
            if (operation())
                return order.ContinueFulfill();

            order.Prime();
            return true;
        }

        public ConductorOrder_While(Operation<bool> o, ConductorOrder co)
        {
            operation = o;
            order = co;
        }
    }
}
