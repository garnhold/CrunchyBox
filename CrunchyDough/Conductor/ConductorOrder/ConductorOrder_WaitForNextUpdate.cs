using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_WaitForNextUpdate : ConductorOrder
    {
        private bool is_ready;

        public ConductorOrder_WaitForNextUpdate()
        {
        }

        public override void InitializeFulfill()
        {
            is_ready = false;
        }

        public override bool UpdateFulfill()
        {
            if (is_ready)
                return true;

            is_ready = true;
            return false;
        }
    }
}
