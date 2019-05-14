using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class Global_Direct : Global
    {
        protected abstract CmlScriptValue_Argument CreateScriptValueArgument();

        public Global_Direct(string n) : base(n) { }

        public override CmlScriptValue CreateScriptValue(CmlScriptValue_Argument_Host host)
        {
            return host.AddArgument(CreateScriptValueArgument());
        }
    }
}