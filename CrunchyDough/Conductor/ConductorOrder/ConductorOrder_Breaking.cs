using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class ConductorOrder_Breaking : ConductorOrder
    {
        private bool is_actually_done;

        protected abstract bool UpdateFulfillInternal();

        protected override bool InitializeFulfill()
        {
            is_actually_done = false;
            return true;
        }

        protected override bool UpdateFulfill()
        {
            if (is_actually_done)
                return true;

            if (UpdateFulfillInternal())
                is_actually_done = true;

            return false;
        }
    }
}
