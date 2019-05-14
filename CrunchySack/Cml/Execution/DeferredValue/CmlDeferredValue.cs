
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlDeferredValue
	{
        private CmlCallContext call_context;
        private CmlValueSource value_source;

        public CmlDeferredValue(CmlCallContext c, CmlValueSource v)
        {
            call_context = c;
            value_source = v;
        }

        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            execution.PushPopCallContext(
                call_context,
                () => value_source.SolidifyInto(execution, container)
            );
        }
	}
	
}
