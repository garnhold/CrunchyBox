using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_WaitUntil : ConductorOrder
    {
        private Operation<bool> operation;

        protected override bool UpdateFulfill()
        {
            if (operation())
                return true;

            return false;
        }

        public ConductorOrder_WaitUntil(Operation<bool> o)
        {
            operation = o;
        }
    }
}
