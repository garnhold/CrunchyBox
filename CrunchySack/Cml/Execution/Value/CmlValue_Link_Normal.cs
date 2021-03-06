
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 21:52:01 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlValue_Link_Normal : CmlValue_Link
	{
        private VariableInstance variable_instance;
        private HasInfo info;

        public CmlValue_Link_Normal(VariableInstance v, HasInfo i)
        {
            variable_instance = v;
            info = i;
        }

        public override CmlScriptValue_Argument CreateScriptArgument()
        {
            return new CmlScriptValue_Argument_Single_VariableInstance(variable_instance);
        }

        public override string GetGroup()
        {
            return info.GetInfoValue("group");
        }

        public override EffigyClassInfo GetClass()
        {
            return new EffigyClassInfo_Dynamic(info.GetInfoValue("layout"));
        }

        public override VariableInstance GetVariableInstance()
        {
            return variable_instance;
        }
    }
	
}
