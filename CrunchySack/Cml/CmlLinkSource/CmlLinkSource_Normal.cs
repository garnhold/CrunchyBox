
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
    
    public partial class CmlLinkSource_Normal : CmlLinkSource, HasInfo
	{
        static private LookupSet<string, string> DEFAULT_ATTRIBUTE_INFO_VALUES = new StringTable(
            KeyValuePair.New("group", DEFAULT_GROUP),
            KeyValuePair.New("layout", DEFAULT_LAYOUT)
        );

        public override void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            container.Insert(execution,
                new CmlValue_Link(GetLink().CompileVariableInstance(execution), this)
            );
        }

        public LookupBackedSet<string, string> GetInfoSettings()
        {
            return GetInfo().CreateBackedSet(DEFAULT_ATTRIBUTE_INFO_VALUES);
        }
	}
	
}
