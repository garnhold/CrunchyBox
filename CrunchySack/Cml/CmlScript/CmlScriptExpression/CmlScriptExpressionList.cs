
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
    
    public partial class CmlScriptExpressionList : CmlElement, CmlScriptElement
	{
        public void Compile(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetExpressions().Process(e => e.Compile(context, request, request));
        }

        public IEnumerable<CmlScriptValue> GetValues()
        {
            return GetExpressions().Convert(e => e.GetValue());
        }

        public int GetNumberExpressions()
        {
            return expressions.Count;
        }
	}
	
}
