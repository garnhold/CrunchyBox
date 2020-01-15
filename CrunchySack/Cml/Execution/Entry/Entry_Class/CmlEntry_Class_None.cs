
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 22:31:32 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlEntry_Class_None : CmlEntry_Class
	{
        protected override void SolidifyIntoInternalClass(CmlExecution execution, CmlContainer container)
        {
            container.Insert(
                execution,
                new CmlValue_SystemValue(execution.GetTargetInfo().GetTarget())
            );
        }

        public CmlEntry_Class_None(Type t) : base(t, "none")
        {
        }
	}
	
}
