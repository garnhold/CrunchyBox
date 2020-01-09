
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
    
    public abstract partial class CmlScriptValueReference : CmlElement, CmlScriptElement
	{
        private CmlScriptValue value;

        protected abstract CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value);

        public void Compile(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            value = CompileValue(execution, request, this_value);
        }

        public CmlScriptValue GetValue()
        {
            return value;
        }
	}
	
}
