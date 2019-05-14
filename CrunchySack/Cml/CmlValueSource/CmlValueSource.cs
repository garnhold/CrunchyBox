
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 22:26:50 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public abstract partial class CmlValueSource : CmlElement
	{
        public abstract void SolidifyInto(CmlExecution execution, CmlContainer container);

        public CmlDeferredValue CreateDeferred(CmlExecution execution)
        {
            return new CmlDeferredValue(execution.GetCallContext(), this);
        }
	}
	
}
