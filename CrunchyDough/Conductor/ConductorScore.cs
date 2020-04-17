using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorScore : IDisposable
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

        private ConductorOrder GetCurrentOrder()
        {
            if (is_done == false)
            {
                if (has_started || MoveNextOrder())
                    return iter.Current;
            }

            return null;
        }

        public ConductorScore(IEnumerator<ConductorOrder> i)
        {
            is_done = false;
            has_started = false;

            iter = i;
        }

        public ConductorScore(IEnumerable<ConductorOrder> e) : this(e.GetEnumerator()) { }
        public ConductorScore(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }

        public ConductorScore(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

        public void Dispose()
        {
            iter.Dispose();
        }

        public void Reset()
        {
            is_done = false;
            has_started = false;

            iter.Reset();
        }

        public void Prime()
        {
            is_done = true;
            has_started = true;
        }

        public void StartFulfill()
        {
            GetCurrentOrder().IfNotNull(o => o.StartFulfill());
        }

        public void PauseFulfill()
        {
            GetCurrentOrder().IfNotNull(o => o.PauseFulfill());
        }

        public bool StepFulfill()
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

        public bool IsDone()
        {
            return is_done;
        }
    }
}
