
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
    
    public abstract class CmlScriptValue_Argument : CmlScriptValue
    {
        private ILValue il_value;

        public abstract object GetArgument();
        public abstract CmlScriptParameter GetParameter();

        public void Initialize(ILValue v)
        {
            il_value = v.GetILImplicitCast(GetValueType());
        }

        public override ILValue GetILValue()
        {
            return il_value;
        }
    }
	
}
