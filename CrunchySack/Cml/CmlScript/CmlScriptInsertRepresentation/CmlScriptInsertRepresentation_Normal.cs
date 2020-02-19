
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlScriptInsertRepresentation_Normal : CmlScriptInsertRepresentation
	{
        protected override CmlScriptValue CompileValue(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            return request.InsertRepresentationValue(GetId())
                .AssertNotNull(() => new CmlRuntimeError_InvalidIdException("representation", GetId()));
        }
	}
	
}
