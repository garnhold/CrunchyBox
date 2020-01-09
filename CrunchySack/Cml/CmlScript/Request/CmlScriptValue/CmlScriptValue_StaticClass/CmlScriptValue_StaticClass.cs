
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
    using Sodium;
    using Noodle;
    
    public class CmlScriptValue_StaticClass : CmlScriptValue
    {
        private Type static_type;

        public CmlScriptValue_StaticClass(Type st)
        {
            static_type = st;
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
            return static_type.GetStaticField(id)
                .IfNotNull(f => f.GetStaticILField())
                .IfNotNull(f => new CmlScriptValue_Basic(f));
        }

        public override CmlScriptValue GetIndirectMethodInvokation(string id, IEnumerable<CmlScriptValue> values)
        {
            return static_type.GetStaticMethod(id, values.Convert(v => v.GetValueType()))
                .IfNotNull(m => m.GetStaticILMethodInvokation(values.Convert(v => v.GetILValue())))
                .IfNotNull(m => new CmlScriptValue_Basic(m));
        }
    }
}
