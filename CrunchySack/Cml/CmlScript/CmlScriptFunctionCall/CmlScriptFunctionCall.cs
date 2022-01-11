
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
    
    public partial class CmlScriptFunctionCall : CmlElement, CmlScriptElement
	{
        private CmlScriptValue value;

        public void Compile(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetArguments().Compile(context, request, this_value);

            value = null;
            if (GetArguments().GetNumberExpressions() == 0)
                value = this_value.GetIndirectValue(GetId());

            if (value == null)
            {
                value = this_value.GetIndirectMethodInvokation(GetId(), GetArguments().GetValues())
                    .AssertNotNull(() => new CmlRuntimeError_InvalidIdForTypeException("function", GetId(), this_value.GetValueType()));
            }
        }

        public CmlScriptValue GetValue()
        {
            return value;
        }
	}
	
}
