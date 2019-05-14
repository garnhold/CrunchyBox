using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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