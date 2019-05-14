
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 21:52:01 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlValue_Function : CmlValue, HasInfo
	{
        private FunctionInstance function_instance;
        private HasInfo info;

        public CmlValue_Function(FunctionInstance a, HasInfo i)
        {
            function_instance = a;
            info = i;
        }

        public override CmlScriptValue_Argument CreateScriptArgument()
        {
            return new CmlScriptValue_Argument_Single_FunctionInstance(function_instance);
        }

        public FunctionInstance GetFunctionInstance()
        {
            return function_instance;
        }

        public LookupBackedSet<string, string> GetInfoSettings()
        {
            return info.GetInfoSettings();
        }
	}
	
}
