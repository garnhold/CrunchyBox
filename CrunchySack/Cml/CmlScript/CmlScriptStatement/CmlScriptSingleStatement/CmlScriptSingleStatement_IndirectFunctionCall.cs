
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:14:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlScriptSingleStatement_IndirectFunctionCall : CmlScriptSingleStatement
	{
        protected override ILStatement CompileILStatement(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetIndirectionExpression().Compile(execution, request, this_value);
            GetFunctionCall().Compile(execution, request, GetIndirectionExpression().GetValue());

            return GetFunctionCall().GetValue().GetILValue().CreateILCalculate();
        }
	}
	
}
