
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
    
    public partial class CmlScriptStatement_While : CmlScriptStatement
	{
        protected override ILStatement CompileILStatement(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetConditionExpression().Compile(context, request, this_value);
            GetWhileStatement().Compile(context, request, this_value);

            return new ILWhile(
                GetConditionExpression().GetValue().GetILValue(),
                GetWhileStatement().GetILStatement()
            );
        }
	}
	
}
