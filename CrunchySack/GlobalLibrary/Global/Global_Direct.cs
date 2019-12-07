using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
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