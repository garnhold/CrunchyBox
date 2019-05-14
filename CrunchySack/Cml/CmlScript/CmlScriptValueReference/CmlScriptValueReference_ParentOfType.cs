
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
    public partial class CmlScriptValueReference_ParentOfType : CmlScriptValueReference
	{
        protected override CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            return request.GetParentOfTypeValue(GetParentType());
        }

        public Type GetParentType()
        {
            return Types.GetFilteredTypes(
                Filterer_Type.IsNamed(GetTypeName())
            ).GetFirst()
            .AssertNotNull(() => new CmlRuntimeError_InvalidIdException("parent type", GetTypeName()));
        }
	}
	
}
