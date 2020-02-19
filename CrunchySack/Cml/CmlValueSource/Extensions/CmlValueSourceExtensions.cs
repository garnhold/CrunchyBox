using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class CmlValueSourceExtensions
	{
        static public object Instance(this CmlValueSource item, CmlContext context)
        {
            return item.GetValue(context).ForceSystemValue();
        }
	}
	
}
