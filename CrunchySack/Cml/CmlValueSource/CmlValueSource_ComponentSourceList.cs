
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
    
    public partial class CmlValueSource_ComponentSourceList : CmlValueSource
	{
        public override CmlValue GetValue(CmlContext context)
        {
            return GetComponentSourceList().Solidify(context);
        }
    }
	
}
