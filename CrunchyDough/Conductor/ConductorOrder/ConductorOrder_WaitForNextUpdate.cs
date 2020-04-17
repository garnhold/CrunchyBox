using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_WaitForNextUpdate : ConductorOrder
    {
        private bool is_ready;

        protected override bool InitializeFulfill()
        {
            is_ready = false;
            return true;
        }

        protected override bool UpdateFulfill()
        {
            if (is_ready)
                return true;

            is_ready = true;
            return false;
        }

        public ConductorOrder_WaitForNextUpdate()
        {
        }
    }
}
