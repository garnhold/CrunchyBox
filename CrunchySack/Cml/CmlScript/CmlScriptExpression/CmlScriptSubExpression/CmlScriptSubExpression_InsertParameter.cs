
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
    
    public partial class CmlScriptSubExpression_InsertParameter : CmlScriptSubExpression
	{
        protected override CmlScriptValue CompileValue(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            CmlContainer_Value container = new CmlContainer_Value();

            GetInsertParameter().SolidifyInto(context, container, true);
            return request.AddSecondaryArgument(container.GetValue().CreateScriptArgument());
        }
	}
	
}
