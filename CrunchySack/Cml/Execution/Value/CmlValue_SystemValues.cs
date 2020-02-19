
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlValue_SystemValues : CmlValue
	{
        private List<object> system_values;

        public CmlValue_SystemValues(IEnumerable<object> vs)
        {
            system_values = vs.ToList();
        }

        public IEnumerable<object> GetSystemValues()
        {
            return system_values;
        }
	}
	
}
