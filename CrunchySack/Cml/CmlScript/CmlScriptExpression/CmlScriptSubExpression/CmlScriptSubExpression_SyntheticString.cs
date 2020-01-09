
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlScriptSubExpression_SyntheticString : CmlScriptSubExpression
	{
        protected override CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetSyntheticString().Compile(execution, request, this_value);

            return GetSyntheticString().GetValue();
        }
	}
	
}
