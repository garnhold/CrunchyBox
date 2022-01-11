
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
    
    public class CmlScriptValue_IndirectGlobal : CmlScriptValue
    {
        private Global_Indirect global;
        private CmlScriptValue_Argument_Host host;

        private Dictionary<string, CmlScriptValue> indirect_values;

        public CmlScriptValue_IndirectGlobal(Global_Indirect g, CmlScriptValue_Argument_Host h)
        {
            global = g;
            host = h;

            indirect_values = new Dictionary<string, CmlScriptValue>();
        }

        public override Type GetValueType()
        {
            return null;
        }

        public override ILValue GetILValue()
        {
            return null;
        }

        public override CmlScriptValue GetIndirectValue(string id)
        {
            return indirect_values.GetOrCreateValue(id, delegate() {
                return global.GetIndirectValue(id, host);
            });
        }
    }
}
