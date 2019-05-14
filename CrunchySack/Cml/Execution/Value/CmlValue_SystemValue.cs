
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlValue_SystemValue : CmlValue
	{
        private object system_value;

        public CmlValue_SystemValue(object v)
        {
            system_value = v;
        }

        public override CmlScriptValue_Argument CreateScriptArgument()
        {
            return new CmlScriptValue_Argument_Single_Constant(system_value);
        }

        public object GetSystemValue()
        {
            return system_value;
        }
	}
	
}
