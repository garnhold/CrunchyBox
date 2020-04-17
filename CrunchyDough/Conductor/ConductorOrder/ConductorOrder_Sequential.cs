using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Sequential : ConductorOrder
    {
        private bool is_done;
        private bool has_started;

        private IEnumerator<ConductorOrder> iter;

        private bool MoveNextOrder()
        {
            if (is_done == false)
            {
                if (iter.MoveNext())
                {
                    iter.Current.InitializeFulfill();

                    has_started = true;
                    return true;
                }
            }

            is_done = true;
            return false;
        }

        private bool StepFulfill()
        {
            if (GetCurrentOrder().IfNotNull(o => o.UpdateFulfill()))
            {
                if (MoveNextOrder())
                {
                    StartFulfill();

                    return true;
                }
            }

            return false;
        }

        private ConductorOrder GetCurrentOrder()
        {
            if (is_done == false)
            {
                if (has_started || MoveNextOrder())
                    return iter.Current;
            }

            return null;
        }

        public ConductorOrder_Sequential(IEnumerator<ConductorOrder> i)
        {
            is_done = false;
            has_started = false;

            iter = i;
        }

        public ConductorOrder_Sequential(IEnumerable<ConductorOrder> e) : this(e.GetEnumerator()) { }
        public ConductorOrder_Sequential(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }

        public ConductorOrder_Sequential(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

        public override void InitializeFulfill()
        {
            is_done = false;
            has_started = false;

            iter.Reset();
        }

        public override void StartFulfill()
        {
            GetCurrentOrder().IfNotNull(o => o.StartFulfill());
        }

        public override void PauseFulfill()
        {
            GetCurrentOrder().IfNotNull(o => o.PauseFulfill());
        }

        public override bool UpdateFulfill()
        {
            while (StepFulfill()) ;
            return is_done;
        }
    }
}
