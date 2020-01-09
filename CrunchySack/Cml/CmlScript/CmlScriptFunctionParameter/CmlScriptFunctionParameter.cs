
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
    
    public partial class CmlScriptFunctionParameter : CmlElement
	{
        public void Inject(CmlScriptValue_Argument_Host host, CmlScriptRequest request)
        {
            request.AddExplicitIndirectValue(
                GetName(),
                host.AddArgument(new CmlScriptValue_Argument_Single_Placeholder(GetParameterType()))
            );
        }

        public Type GetParameterType()
        {
            return Types.GetFilteredTypes(
                Filterer_Type.IsNamed(GetTypeName())
            ).GetFirst()
            .AssertNotNull(() => new CmlRuntimeError_InvalidIdException("parameter type", GetTypeName()));
        }

        public override string ToString()
        {
            return GetParameterType() + " " + GetName();
        }
	}
	
}
