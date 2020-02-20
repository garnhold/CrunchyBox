
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
    
    public partial class CmlScriptLambda_Single : CmlScriptLambda
	{
        protected override ILStatement CompileILStatement(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetSingleStatement().Compile(context, request, this_value);

            return GetSingleStatement().GetILStatement();
        }
	}
	
}
