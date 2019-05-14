
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
    public class CmlScriptValue_Argument_Single_Placeholder : CmlScriptValue_Argument_Single
    {
        private Type argument_type;

        public CmlScriptValue_Argument_Single_Placeholder(Type t)
        {
            argument_type = t;
        }

        public override object GetArgument()
        {
            throw new InvalidOperationException("GetArgument() should not be called on CmlScriptArgument_Single_Placeholder");
        }

        public override Type GetValueType()
        {
            return argument_type;
        }
    }
	
}
