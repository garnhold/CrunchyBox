
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
        protected override ILStatement CompileILStatement(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetIndirectionExpression().Compile(context, request, this_value);
            GetValueReference().Compile(context, request, GetIndirectionExpression().GetValue());

            GetExpression().Compile(context, request, this_value);

            return new ILAssign(
                GetValueReference().GetValue().GetILValue(),
                GetExpression().GetValue().GetILValue()
            );
        }
	}
	
}
