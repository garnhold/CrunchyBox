
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 17 2018 23:01:00 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlLinkSourceWithEntitySource : CmlElement
	{
        public CmlValue_LinkWithEntity Solidify(CmlContext context)
        {
            return new CmlValue_LinkWithEntity(
                GetLinkSource().Solidify(context),
                GetEntity()
            );
        }
	}
	
}
