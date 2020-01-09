using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_WaitUntil : ConductorOrder
    {
        private Operation<bool> operation;

        public ConductorOrder_WaitUntil(Operation<bool> o)
        {
            operation = o;
        }

        public override bool Fulfill()
        {
            if (operation())
                return true;

            return false;
        }
    }
}
