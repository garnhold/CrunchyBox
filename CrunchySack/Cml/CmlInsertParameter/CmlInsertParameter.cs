
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
                context.GetParameterSpace().IfNotNull(s => s.GetParameter(GetId())).IfNotNull(p => p.Solidify()) ??
                GetDefaultValueSource().IfNotNull(s => s.Solidify(context))
            )
            .AssertNotNull(assert, () => new CmlRuntimeError_InvalidIdException("parameter", GetId()));
        }

        public CmlValue_Link SolidifyLink(CmlContext context, bool assert)
        {
            return Solidify(context, assert)
                .AssertConvert<CmlValue, CmlValue_Link>(assert, () => new CmlRuntimeError_UnexpectedInsertParameterTypeException(typeof(CmlValue_Link), GetId()));
        }

        public CmlValue_Function SolidifyFunction(CmlContext context, bool assert)
        {
            return Solidify(context, assert)
                .AssertConvert<CmlValue, CmlValue_Function>(assert, () => new CmlRuntimeError_UnexpectedInsertParameterTypeException(typeof(CmlValue_Function), GetId()));
        }

        public object Instance(CmlContext context, bool assert)
        {
            return Solidify(context, assert).ForceSystemValue();
        }
	}
	
}
