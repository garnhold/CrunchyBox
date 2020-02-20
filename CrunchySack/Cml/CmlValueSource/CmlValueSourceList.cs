
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 22:26:50 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlValueSourceList : CmlElement
	{
        public IEnumerable<object> Instance(CmlContext context)
        {
            return GetValueSources().Convert(s => s.Instance(context));
        }

        public CmlValue Solidify(CmlContext context)
        {
            return new CmlValue_SystemValues(Instance(context));
        }
	}
	
}
