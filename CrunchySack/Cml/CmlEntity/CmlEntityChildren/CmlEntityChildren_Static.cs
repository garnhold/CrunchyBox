
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 23:37:16 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlEntityChildren_Static : CmlEntityChildren
	{
        public override CmlValue GetValue(CmlContext context)
        {
            return new CmlValue_SystemValues(
                GetComponentSourceList().Instance(context)
            );
        }
    }
	
}
