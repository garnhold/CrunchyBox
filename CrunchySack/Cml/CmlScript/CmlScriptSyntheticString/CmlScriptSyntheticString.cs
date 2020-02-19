
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
    
    public partial class CmlScriptSyntheticString : CmlElement, CmlScriptElement
	{
        private CmlScriptValue value;

        private void LoadContextIntermediateString(string input)
        {
            SetString(input.ExtractStringValueFromLiteralString());
        }

        public void Compile(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            value = new CmlScriptValue_Basic(
                new ILStringExpression(
                    GetString(),
                    s => CmlScriptExpression.DOMify(s)
                        .Chain(z => z.Compile(context, request, this_value))
                        .GetValue()
                        .GetILValue()
                )
            );
        }

        public CmlScriptValue GetValue()
        {
            return value;
        }
	}
	
}
