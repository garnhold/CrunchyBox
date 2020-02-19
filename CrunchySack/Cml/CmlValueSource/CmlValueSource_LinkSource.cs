
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 17 2018 18:52:55 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlValueSource_LinkSource : CmlValueSource
	{
        public override CmlValue GetValue(CmlContext context)
        {
            return GetLinkSource().Solidify(context);
        }
    }
	
}
