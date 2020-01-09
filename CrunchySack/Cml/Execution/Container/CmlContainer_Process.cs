
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlContainer_Process : CmlContainer
	{
        private Process<CmlExecution, CmlValue> process;

        protected override void InsertInternal(CmlExecution execution, CmlValue value)
        {
            process(execution, value);
        }

        public CmlContainer_Process(Process<CmlExecution, CmlValue> p)
        {
            process = p;
        }
	}
}
