
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlPrimitive_String : CmlPrimitive
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
