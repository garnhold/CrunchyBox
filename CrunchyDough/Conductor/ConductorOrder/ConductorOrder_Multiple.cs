using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class ConductorOrder_Multiple : ConductorOrder
    {
        protected abstract IEnumerable<ConductorOrder> GetActive();

        public override void InitializeFulfill()
        {
            GetActive().Process(o => o.InitializeFulfill());
        }

        public override void StartFulfill()
        {
            GetActive().Process(o => o.StartFulfill());
        }

        public override void PauseFulfill()
        {
            GetActive().Process(o => o.PauseFulfill());
        }
    }
}
