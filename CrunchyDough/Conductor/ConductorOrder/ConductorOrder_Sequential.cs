using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ConductorOrder_Sequential : ConductorOrder
    {
        private List<ConductorOrder> orders;

        public ConductorOrder_Sequential(IEnumerable<ConductorOrder> o)
        {
            orders = o.ToList();
        }

        public ConductorOrder_Sequential(params ConductorOrder[] o) : this((IEnumerable<ConductorOrder>)o) { }

        public override bool Fulfill()
        {
            if (orders.GetFirst().IfNotNull(o => o.Fulfill()))
                orders.Pop();

            if (orders.IsEmpty())
                return true;

            return false;
        }
    }
}
