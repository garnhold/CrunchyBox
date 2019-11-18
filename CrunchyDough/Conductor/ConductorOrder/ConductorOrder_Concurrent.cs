using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ConductorOrder_Concurrent : ConductorOrder
    {
        private List<ConductorOrder> orders;

        public ConductorOrder_Concurrent(IEnumerable<ConductorOrder> o)
        {
            orders = o.ToList();
        }

        public ConductorOrder_Concurrent(params ConductorOrder[] o) : this((IEnumerable<ConductorOrder>)o) { }

        public override bool Fulfill()
        {
            orders.RemoveAll(o => o.Fulfill());

            if (orders.IsEmpty())
                return true;

            return false;
        }
    }
}
