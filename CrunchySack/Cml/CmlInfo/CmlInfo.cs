
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 4/13/2017 9:16:12 PM

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlInfo : CmlElement, LookupSet<string, string>
	{
        public bool Has(string key)
        {
            return GetSettings().Has(key);
        }

        public bool TryLookup(string key, out string value)
        {
            CmlInfoSetting setting;

            if(GetSettings().TryLookup(key, out setting))
            {
                value = setting.GetValue();
                return true;
            }

            value = "";
            return false;
        }
	}
	
}
