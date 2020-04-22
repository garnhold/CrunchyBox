using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class ConductorOrder_Sequence : ConductorOrder
    {
        private ConductorOrder_Sequential sequential;

        protected virtual void SequenceBegin() { }
        protected virtual void SequenceEnd() { }

        protected abstract IEnumerable<ConductorOrder> Sequence();

        protected override bool InitializeFulfill()
        {
            sequential.Reset();

            SequenceBegin();
            return true;
        }

        protected override void StartFulfill()
        {
            sequential.ResumeFulfill();
        }

        protected override void PauseFulfill()
        {
            sequential.SuspendFulfill();
        }

        protected override void CancelFulfill()
        {
            sequential.Reset();
        }

        protected override void FinishFulfill()
        {
            sequential.Prime();
        }

        protected override void DoneFulfill()
        {
            SequenceEnd();
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
