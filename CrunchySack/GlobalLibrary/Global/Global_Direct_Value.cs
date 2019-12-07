using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class Global_Direct_Value : Global_Direct
    {
        private object target;

        protected override CmlScriptValue_Argument CreateScriptValueArgument()
        {
            return new CmlScriptValue_Argument_Single_Constant(target);
        }

        public Global_Direct_Value(string n, object t) : base(n)
        {
            target = t;
        }
    }
}