using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class Global_Direct_Operation<T> : Global_Direct
    {
        private Operation<T> operation;

        protected override CmlScriptValue_Argument CreateScriptValueArgument()
        {
            return new CmlScriptValue_Argument_Single_Operation<T>(operation);
        }

        public Global_Direct_Operation(string n, Operation<T> o) : base(n)
        {
            operation = o;
        }
    }
}