
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 20:16:12 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract partial class CmlFunctionSource : CmlElement
	{
        public abstract void SolidifyInto(CmlExecution execution, CmlContainer container);

        public CmlValue_Function SolidifyFunction(CmlExecution execution)
        {
            CmlContainer_Value value = new CmlContainer_Value();

            SolidifyInto(execution, value);
            return value.GetValue<CmlValue_Function>();
        }
	}
	
}
