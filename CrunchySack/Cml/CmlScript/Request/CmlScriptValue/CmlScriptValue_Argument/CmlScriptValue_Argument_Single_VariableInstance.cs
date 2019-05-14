
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
    public class CmlScriptValue_Argument_Single_VariableInstance : CmlScriptValue_Argument_Single
    {
        private VariableInstance variable_instance;
        
        public CmlScriptValue_Argument_Single_VariableInstance(VariableInstance v)
        {
            variable_instance = v;
        }

        public override object GetArgument()
        {
            return variable_instance.GetContents();
        }

        public override Type GetValueType()
        {
            return variable_instance.GetVariableType();
        }
    }

}
