using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ConductorOrder_Compound : ConductorOrder
    {
        private List<ConductorOrder> orders;

        public ConductorOrder_Compound(IEnumerable<ConductorOrder> o)
        {
            orders = o.ToList();
        }

        public ConductorOrder_Compound(params ConductorOrder[] o) : this((IEnumerable<ConductorOrder>)o) { }

        public override bool Fulfill()
        {
            orders.RemoveAll(o => o.Fulfill());

            if (orders.IsEmpty())
                return true;

            return false;
        }
    }
}
