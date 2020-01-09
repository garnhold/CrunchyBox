
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:15:13 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorLiteral_String : CMinorLiteral
	{
        private void LoadContextIntermediateString(string input)
        {
            SetString(input.ExtractStringValueFromLiteralString());
        }

        public override object GetSystemValue()
        {
            return GetString();
        }
	}
	
}
