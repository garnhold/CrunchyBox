
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
    
    public partial class CmlFunctionSource_Normal : CmlFunctionSource, HasInfo
	{
        static private LookupSet<string, string> DEFAULT_ATTRIBUTE_INFO_VALUES = new StringTable(
        );

        public override CmlValue Solidify(CmlContext context)
        {
            return new CmlValue_Function(GetFunction().CompileFunctionInstance(context), this);
        }

        public LookupBackedSet<string, string> GetInfoSettings()
        {
            return GetInfo().CreateBackedSet(DEFAULT_ATTRIBUTE_INFO_VALUES);
        }
	}
	
}
