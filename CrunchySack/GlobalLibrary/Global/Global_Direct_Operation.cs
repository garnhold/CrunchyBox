using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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