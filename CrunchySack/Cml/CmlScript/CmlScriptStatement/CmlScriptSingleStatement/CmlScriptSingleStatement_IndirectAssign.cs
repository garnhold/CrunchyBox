
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
    
    public partial class CmlScriptSingleStatement_IndirectAssign : CmlScriptSingleStatement
	{
        protected override ILStatement CompileILStatement(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetIndirectionExpression().Compile(execution, request, this_value);
            GetValueReference().Compile(execution, request, GetIndirectionExpression().GetValue());

            GetExpression().Compile(execution, request, this_value);

            return new ILAssign(
                GetValueReference().GetValue().GetILValue(),
                GetExpression().GetValue().GetILValue()
            );
        }
	}
	
}
