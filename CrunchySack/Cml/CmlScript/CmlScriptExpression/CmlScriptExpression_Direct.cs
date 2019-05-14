
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
	public partial class CmlScriptExpression_Direct : CmlScriptExpression, CmlScriptElement
	{
        protected override CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetSubExpression().Compile(execution, request, request);

            return GetSubExpression().GetValue();
        }
	}
	
}
