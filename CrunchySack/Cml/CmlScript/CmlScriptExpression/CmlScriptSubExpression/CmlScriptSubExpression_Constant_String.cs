
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
    
    public partial class CmlScriptSubExpression_Constant_String : CmlScriptSubExpression_Constant
	{
        protected override object GetConstant()
        {
            return GetString();
        }

        private void LoadContextIntermediateString(string input)
        {
            SetString(input.ExtractStringValueFromLiteralString());
        }
	}
	
}
