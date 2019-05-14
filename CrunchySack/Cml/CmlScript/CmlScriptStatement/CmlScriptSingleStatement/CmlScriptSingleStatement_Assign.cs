
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
	public partial class CmlScriptSingleStatement_Assign : CmlScriptSingleStatement
	{
        protected override ILStatement CompileILStatement(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetValueReference().Compile(execution, request, this_value);
            GetExpression().Compile(execution, request, this_value);

            return new ILAssign(
                GetValueReference().GetValue().GetILValue(),
                GetExpression().GetValue().GetILValue()
            );
        }
	}
	
}
