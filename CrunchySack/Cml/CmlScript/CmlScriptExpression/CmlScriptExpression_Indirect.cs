
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:33:22 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlScriptExpression_Indirect : CmlScriptExpression
	{
        protected override CmlScriptValue CompileValue(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetIndirectionExpression().Compile(context, request, this_value);
            GetSubExpression().Compile(context, request, GetIndirectionExpression().GetValue());

            return GetSubExpression().GetValue();
        }
	}
	
}
