
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
    public class CmlScriptValue_Argument_Single_Constant : CmlScriptValue_Argument_Single
    {
        private object constant;

        public CmlScriptValue_Argument_Single_Constant(object c)
        {
            constant = c;
        }

        public override object GetArgument()
        {
            return constant;
        }

        public override Type GetValueType()
        {
            return constant.GetTypeEX();
        }
    }
	
}
