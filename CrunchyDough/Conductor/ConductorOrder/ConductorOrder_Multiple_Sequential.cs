using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Multiple_Sequential : ConductorOrder_Multiple
    {
        private int current_order_index;
        private List<ConductorOrder> orders;

        protected override IEnumerable<ConductorOrder> GetActive()
        {
            return orders.Offset(current_order_index);
        }

        public ConductorOrder_Multiple_Sequential(IEnumerable<ConductorOrder> o)
        {
            current_order_index = 0;
            orders = o.ToList();
        }

        public ConductorOrder_Multiple_Sequential(params ConductorOrder[] o) : this((IEnumerable<ConductorOrder>)o) { }

        public override void InitializeFulfill()
        {
            current_order_index = 0;

            base.InitializeFulfill();
        }

        public override bool UpdateFulfill()
        {
            while (orders.GetDropped(current_order_index).IfNotNull(o => o.UpdateFulfill()))
                current_order_index++;

            if (current_order_index >= orders.Count())
                return true;

            return false;
        }
    }
}
