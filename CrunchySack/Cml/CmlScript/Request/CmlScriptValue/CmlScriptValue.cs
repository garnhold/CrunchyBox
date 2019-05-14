
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchySack
{
    public abstract class CmlScriptValue
    {
        public abstract Type GetValueType();
        public abstract ILValue GetILValue();

        public virtual CmlScriptValue GetIndirectValue(string id)
        {
            return GetILValue()
                .IfNotNull(v => v.GetILProp(id))
                .IfNotNull(v => new CmlScriptValue_Basic(v));
        }

        public virtual CmlScriptValue GetIndirectMethodInvokation(string id, IEnumerable<CmlScriptValue> values)
        {
            return GetILValue()
                .IfNotNull(v => v.GetInstanceILMethodInvokation(id, values.Convert(z => z.GetILValue())))
                .IfNotNull(v => new CmlScriptValue_Basic(v));
        }
    }
	
}
