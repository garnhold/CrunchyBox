using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Multiple_Concurrent : ConductorOrder_Multiple
    {
        private List<ConductorOrder> orders;
        private List<ConductorOrder> order_queue;

        protected override IEnumerable<ConductorOrder> GetActive()
        {
            return order_queue;
        }

        public ConductorOrder_Multiple_Concurrent(IEnumerable<ConductorOrder> o)
        {
            orders = o.ToList();
            order_queue = new List<ConductorOrder>();
        }

        public ConductorOrder_Multiple_Concurrent(params ConductorOrder[] o) : this((IEnumerable<ConductorOrder>)o) { }

        public override void InitializeFulfill()
        {
            order_queue.Set(orders);

            base.InitializeFulfill();
        }

        public override bool UpdateFulfill()
        {
            orders.RemoveAll(o => o.UpdateFulfill());

            if (orders.IsEmpty())
                return true;

            return false;
        }
    }
}
