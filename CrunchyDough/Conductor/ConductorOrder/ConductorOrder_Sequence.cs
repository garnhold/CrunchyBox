using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class ConductorOrder_Sequence : ConductorOrder
    {
        private ConductorOrder_Sequential sequential;

        protected abstract IEnumerable<ConductorOrder> Sequence();

        protected override bool InitializeFulfill()
        {
            sequential.Reset();
            return true;
        }

        protected override void PauseFulfill()
        {
            sequential.SuspendFulfill();
        }

        protected override bool UpdateFulfill()
        {
            return sequential.ContinueFulfill();
        }

        public ConductorOrder_Sequence()
        {
            sequential = new ConductorOrder_Sequential(Sequence);
        }
    }
}
