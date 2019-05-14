
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
	public partial class CmlScriptExpressionList : CmlElement, CmlScriptElement
	{
        public void Compile(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetExpressions().Process(e => e.Compile(execution, request, request));
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
