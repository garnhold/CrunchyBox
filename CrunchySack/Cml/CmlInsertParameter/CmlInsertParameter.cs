
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
            context.GetParameterSpace().IfNotNull(s => s.GetParameter(GetId())).IfNotNull(
                p => p.SolidifyInto(context, container),
                () => GetDefaultValueSource().IfNotNull(
                    v => v.SolidifyInto(context, container),
                    () => assert.ThrowIfTrue(() => new CmlRuntimeError_InvalidIdException("parameter", GetId()))
                )
            );
        }

        public object Instance(CmlContext context)
        {
        }

        public void PushToRepresentation(CmlContext context, object representation, RepresentationInfo info)
        {
            fjk
        }
	}
	
}
