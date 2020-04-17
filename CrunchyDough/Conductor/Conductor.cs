using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Conductor : TemporalEvent
    {
        private bool is_running;

        private bool is_done;
        private ConductorOrder order;

        public Conductor(ConductorOrder o)
        {
            is_running = false;

            is_done = false;
            order = o;
        }

        public Conductor(IEnumerable<ConductorOrder> e) : this(new ConductorOrder_Sequential(e)) { }
        public Conductor(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }
        public Conductor(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

        public Conductor() : this((ConductorOrder)null) { }

        public void SetOrder(ConductorOrder o)
        {
            is_done = false;
            order = o;
        }

        public bool Start()
        {
            if (is_running == false)
            {
                if (is_done == false)
                    order.IfNotNull(s => s.StartFulfill());

                is_running = true;
                return true;
            }

            return false;
        }

        public bool Pause()
        {
            if (is_running)
            {
                if (is_done == false)
                    order.IfNotNull(s => s.PauseFulfill());

                is_running = false;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            is_done = false;
            order.IfNotNull(s => s.InitializeFulfill());
        }

        public void Prime()
        {
            is_done = true;
        }

        public bool UpdateFulfill()
        {
            if (is_running && is_done == false && order != null)
            {
                if (order.UpdateFulfill())
                    is_done = true;

                return is_done;
            }

            return true;
        }

        public bool IsRunning()
        {
            return is_running;
        }

        public bool IsTimeOver()
        {
            return is_done;
        }
    }
}
