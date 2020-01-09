
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:33:22 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract partial class CmlScriptBinaryOperator : CmlElement
	{
        private CmlScriptValue value;

        public abstract BinaryOperatorType GetOperatorType();

        public void Compile(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value, CmlScriptValue l, CmlScriptValue r)
        {
            value = new CmlScriptValue_Basic(
                new ILBinaryOperatorInvokation(GetOperatorType(), l.GetILValue(), r.GetILValue())
            );
        }

        public CmlScriptValue GetValue()
        {
            return value;
        }
	}
	
}
