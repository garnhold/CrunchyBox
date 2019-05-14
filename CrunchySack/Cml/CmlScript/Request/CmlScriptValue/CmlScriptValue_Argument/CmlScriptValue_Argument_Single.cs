
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

namespace CrunchySack
{
    public abstract class CmlScriptValue_Argument_Single : CmlScriptValue_Argument
    {
        public override CmlScriptParameter GetParameter()
        {
            return new CmlScriptParameter_Single(GetValueType());
        }
    }
	
}
