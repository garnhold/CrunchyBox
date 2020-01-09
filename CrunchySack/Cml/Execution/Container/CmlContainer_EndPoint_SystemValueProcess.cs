
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
    
    public class CmlContainer_EndPoint_SystemValueProcess : CmlContainer_EndPoint
	{
        private Process<object> process;

        protected void InsertInternal(CmlValue_SystemValue value, CmlExecution execution)
        {
            process(value.GetSystemValue());
        }

        public CmlContainer_EndPoint_SystemValueProcess(Process<object> p)
        {
            process = p;
        }
	}
}
