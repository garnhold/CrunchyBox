using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Continue : ConductorOrder
    {
        protected override bool InitializeFulfill()
        {
            return false;
        }

        protected override bool UpdateFulfill()
        {
            return true;
        }
    }
}
