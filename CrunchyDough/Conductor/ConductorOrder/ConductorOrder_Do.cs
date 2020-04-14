using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductorOrder_Do : ConductorOrder
    {
        private Process process;

        public ConductorOrder_Do(Process p)
        {
            process = p;
        }

        public override bool UpdateFulfill()
        {
            process();

            return true;
        }
    }
}
