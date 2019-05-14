
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:33:22 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public partial class CmlScriptExpression_Indirect : CmlScriptExpression
	{
        protected override CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetIndirectionExpression().Compile(execution, request, this_value);
            GetSubExpression().Compile(execution, request, GetIndirectionExpression().GetValue());

            return GetSubExpression().GetValue();
        }
	}
	
}
