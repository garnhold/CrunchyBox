
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
    public class CmlScriptValue_Basic : CmlScriptValue
    {
        private ILValue il_value;

        public CmlScriptValue_Basic(ILValue v)
        {
            il_value = v;
        }

        public override Type GetValueType()
        {
            return il_value.IfNotNull(v => v.GetValueType());
        }

        public override ILValue GetILValue()
        {
            return il_value;
        }
    }
	
}
