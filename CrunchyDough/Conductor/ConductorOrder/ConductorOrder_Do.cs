using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ConductorOrder_Do : ConductorOrder
    {
        private Process process;

        public ConductorOrder_Do(Process p)
        {
            process = p;
        }

        public override bool Fulfill()
        {
            process();

            return true;
        }
    }
}
