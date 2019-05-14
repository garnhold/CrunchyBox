
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
    public class CmlScriptValue_Argument_Host : CmlScriptValue_Argument
    {
        private List<CmlScriptValue_Argument> arguments;

        public CmlScriptValue_Argument_Host()
        {
            arguments = new List<CmlScriptValue_Argument>();
        }

        public CmlScriptValue_Argument AddArgument(CmlScriptValue_Argument to_add)
        {
            arguments.Add(to_add);
            to_add.Initialize(GetILValue().GetILIndexed(arguments.GetFinalIndex()));

            return to_add;
        }

        public override object GetArgument()
        {
            return arguments.Convert(p => p.GetArgument()).ToArray();
        }

        public override Type GetValueType()
        {
            return typeof(object[]);
        }

        public override CmlScriptParameter GetParameter()
        {
            return new CmlScriptParameter_Host(arguments.Convert(p => p.GetParameter()));
        }
    }
	
}
