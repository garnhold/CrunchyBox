using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class Global_Indirect : Global
    {
        public abstract CmlScriptValue GetIndirectValue(string id, CmlScriptValue_Argument_Host host);

        public Global_Indirect(string n) : base(n)
        {
        }

        public override CmlScriptValue CreateScriptValue(CmlScriptValue_Argument_Host host)
        {
            return new CmlScriptValue_IndirectGlobal(this, host);
        }
    }
}