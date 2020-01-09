
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
    
    public class CmlScriptValue_Argument_Single_FunctionInstance : CmlScriptValue_Argument_Single
    {
        private FunctionInstance function_instance;

        public CmlScriptValue_Argument_Single_FunctionInstance(FunctionInstance f)
        {
            function_instance = f;
        }

        public override object GetArgument()
        {
            return function_instance;
        }

        public override Type GetValueType()
        {
            return typeof(FunctionInstance);
        }
    }

}
