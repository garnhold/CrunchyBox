using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Concurrent : ConductorOrder
    {
        private List<ConductorOrder> orders;
        private List<ConductorOrder> order_queue;

        public ConductorOrder_Concurrent(IEnumerable<ConductorOrder> o)
        {
            orders = o.ToList();
            order_queue = new List<ConductorOrder>();
        }

        public ConductorOrder_Concurrent(params ConductorOrder[] o) : this((IEnumerable<ConductorOrder>)o) { }

        public override void InitializeFulfill()
        {
            order_queue.Set(orders);
            order_queue.Process(o => o.InitializeFulfill());
        }

        public override void StartFulfill()
        {
            order_queue.Process(o => o.StartFulfill());
        }

        public override void PauseFulfill()
        {
            order_queue.Process(o => o.PauseFulfill());
        }

        public override bool UpdateFulfill()
        {
            order_queue.RemoveAll(o => o.UpdateFulfill());

            if (order_queue.IsEmpty())
                return true;

            return false;
        }
    }
}
