
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

    public partial class CmlScriptFunctionParameters : CmlElement, CmlScriptElement
	{
        public void Compile(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            CmlScriptValue_Argument_Host parameter_host = request.AddPrimaryArgument(new CmlScriptValue_Argument_Host());

            GetFunctionParameters().Process(p => p.Inject(parameter_host, request));
        }

        public IEnumerable<Type> GetParameterTypes()
        {
            return GetFunctionParameters().Convert(p => p.GetParameterType());
        }

        public override string ToString()
        {
            return "(" + GetFunctionParameters().ToString(", ") + ")";
        }
	}
	
}
