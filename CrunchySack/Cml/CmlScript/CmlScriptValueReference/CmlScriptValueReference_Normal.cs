
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public partial class CmlScriptValueReference_Normal : CmlScriptValueReference
	{
        protected override CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            return this_value.GetIndirectValue(GetId())
                .AssertNotNull(() => new CmlRuntimeError_InvalidIdForTypeException("value", GetId(), this_value.GetValueType()));
        }
	}
	
}
