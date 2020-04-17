using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Conductor : TemporalEvent
    {
        private bool is_running;
        private ConductorOrder order;

        public Conductor(ConductorOrder o)
        {
            is_running = false;
            order = o;
        }

        public Conductor(IEnumerable<ConductorOrder> e) : this(new ConductorOrder_Sequential(e)) { }
        public Conductor(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }
        public Conductor(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

        public Conductor() : this((ConductorOrder)null) { }

        public void SetOrder(ConductorOrder o)
        {
            order = o;
        }

        public bool Start()
        {
            if (is_running == false)
            {
                is_running = true;
                return true;
            }

            return false;
        }

        public bool Pause()
        {
            if (is_running)
            {
                order.IfNotNull(o => o.SuspendFulfill());
                is_running = false;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            order.IfNotNull(o => o.Reset());
        }

        public void Prime()
        {
            order.IfNotNull(o => o.Prime());
        }

        public bool UpdateFulfill()
        {
            if (is_running)
                order.IfNotNull(o => o.ContinueFulfill());

            return IsTimeOver();
        }

        public bool IsRunning()
        {
            return is_running;
        }

        public bool IsTimeOver()
        {
            return order.IfNotNull(o => o.IsDone(), true);
        }
    }
}
