using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Sequential : ConductorOrder
    {
        private IEnumerator<ConductorOrder> iter;

        protected override bool InitializeFulfill()
        {
            iter.Reset();

            return iter.MoveNext();
        }

        protected override void PauseFulfill()
        {
            iter.Current.SuspendFulfill();
        }

        protected override bool UpdateFulfill()
        {
            do
            {
                if (iter.Current.ContinueFulfill() == false)
                    return false;
            }
            while (iter.MoveNext());

            return true;
        }

        public ConductorOrder_Sequential(IEnumerator<ConductorOrder> i)
        {
            iter = i;
        }

        public ConductorOrder_Sequential(IEnumerable<ConductorOrder> e) : this(e.GetEnumerator()) { }
        public ConductorOrder_Sequential(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }

        public ConductorOrder_Sequential(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }
    }
}
