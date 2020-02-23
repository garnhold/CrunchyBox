
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 21:52:01 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlInsertParameter : CmlElement
	{
        public CmlValue Solidify(CmlContext context, bool assert)
        {
            return (
                context.GetFragmentSpace().IfNotNull(s => s.GetParameter(GetId())).IfNotNull(p => p.Solidify()) ??
                GetDefaultValueSource().IfNotNull(s => s.Solidify(context))
            )
            .AssertNotNull(assert, () => new CmlRuntimeError_InvalidIdException("parameter", GetId()));
        }

        public object Instance(CmlContext context, bool assert)
        {
            return Solidify(context, assert).ForceSystemValue();
        }
	}
	
}
