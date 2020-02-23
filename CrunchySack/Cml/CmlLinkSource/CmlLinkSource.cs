
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 20:16:12 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlLinkSource : CmlElement, HasInfo
	{
        public const string DEFAULT_GROUP = "normal";
        public const string DEFAULT_LAYOUT = "normal";

        static private LookupSet<string, string> DEFAULT_ATTRIBUTE_INFO_VALUES = new StringTable(
            KeyValuePair.New("group", DEFAULT_GROUP),
            KeyValuePair.New("layout", DEFAULT_LAYOUT)
        );

        public CmlValue_Link Solidify(CmlContext context)
        {
            return new CmlValue_Link_Normal(GetLink().CompileVariableInstance(context), this);
        }

        public LookupBackedSet<string, string> GetInfoSettings()
        {
            return GetInfo().CreateBackedSet(DEFAULT_ATTRIBUTE_INFO_VALUES);
        }
    }
	
}
