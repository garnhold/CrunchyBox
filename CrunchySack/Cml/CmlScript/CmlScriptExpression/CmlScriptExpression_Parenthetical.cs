
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
    
    public partial class CmlScriptExpression_Parenthetical : CmlScriptExpression
	{
        protected override CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetInnerExpression().Compile(execution, request, this_value);

            return GetInnerExpression().GetValue();
        }
	}
	
}
