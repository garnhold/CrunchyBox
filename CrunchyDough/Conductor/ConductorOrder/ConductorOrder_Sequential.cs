using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Sequential : ConductorOrder
    {
        private IEnumerator<ConductorOrder> iter;
        private IEnumerable<ConductorOrder> enumerable;

        protected override bool InitializeFulfill()
        {
            iter = enumerable.GetEnumerator();

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

        public ConductorOrder_Sequential(IEnumerable<ConductorOrder> e)
        {
            enumerable = e;
        }

        public ConductorOrder_Sequential(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }
        public ConductorOrder_Sequential(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }
    }
}
