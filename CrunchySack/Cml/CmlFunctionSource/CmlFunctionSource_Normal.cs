
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
    public partial class CmlFunctionSource_Normal : CmlFunctionSource, HasInfo
	{
        static private LookupSet<string, string> DEFAULT_ATTRIBUTE_INFO_VALUES = new StringTable(
        );

        public override void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            container.Insert(
                execution,
                new CmlValue_Function(GetFunction().CompileFunctionInstance(execution), this)
            );
        }

        public LookupBackedSet<string, string> GetInfoSettings()
        {
            return GetInfo().CreateBackedSet(DEFAULT_ATTRIBUTE_INFO_VALUES);
        }
	}
	
}
