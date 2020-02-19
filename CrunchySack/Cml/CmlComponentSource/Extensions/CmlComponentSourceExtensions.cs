using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class CmlComponentSourceExtensions
	{
        static public CmlValue GetValue(this CmlComponentSource item, CmlContext context)
        {
            return new CmlValue_SystemValue(item.Instance(context));
        }
	}
	
}
