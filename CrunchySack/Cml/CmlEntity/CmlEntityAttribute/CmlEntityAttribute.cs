//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 1/30/2017 1:49:45 AM


using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlEntityAttribute : CmlElement, CmlEntityInfo
	{
        public void PushToRepresentation(CmlContext context, object representation)
        {
            GetValueSource().PushToRepresentation(
                context,
                representation,
                context.GetEngine().AssertGetInfo(representation.GetTypeEX(), GetName())
            );
        }

        public CmlParameter CreateParameter(CmlContext context)
        {
            return new CmlParameter(
                context,
                GetName(),
                GetValueSource().CreateDeferred(context)
            );
        }
	}
	
}
