using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlValue_None : CmlValue
	{
        public override CmlScriptValue_Argument CreateScriptArgument()
        {
            return new CmlScriptValue_Argument_Single_Constant(null);
        }
	}
}
