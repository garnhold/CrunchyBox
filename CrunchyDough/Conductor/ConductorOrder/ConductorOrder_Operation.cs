using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ConductorOrder_Operation : ConductorOrder
    {
        private Operation<bool> operation;

        public ConductorOrder_Operation(Operation<bool> o)
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
