
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
    public partial class CmlScriptStatement_If : CmlScriptStatement
	{
        protected override ILStatement CompileILStatement(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetConditionExpression().Compile(execution, request, this_value);
            GetTrueStatement().IfNotNull(s => s.Compile(execution, request, this_value));
            GetFalseStatement().IfNotNull(s => s.Compile(execution, request, this_value));

            return new ILIf(
                GetConditionExpression().GetValue().GetILValue(),
                GetTrueStatement().IfNotNull(s => s.GetILStatement()),
                GetFalseStatement().IfNotNull(s => s.GetILStatement())
            );
        }
	}
	
}
