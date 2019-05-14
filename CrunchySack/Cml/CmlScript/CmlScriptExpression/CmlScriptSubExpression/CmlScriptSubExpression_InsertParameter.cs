
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
    public partial class CmlScriptSubExpression_InsertParameter : CmlScriptSubExpression
	{
        protected override CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            CmlContainer_Value container = new CmlContainer_Value();

            GetInsertParameter().SolidifyInto(execution, container, true);
            return request.AddSecondaryArgument(container.GetValue().CreateScriptArgument());
        }
	}
	
}
