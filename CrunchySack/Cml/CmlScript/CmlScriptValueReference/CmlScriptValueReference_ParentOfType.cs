
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
    
    public partial class CmlScriptValueReference_ParentOfType : CmlScriptValueReference
	{
        protected override CmlScriptValue CompileValue(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
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
