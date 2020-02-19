
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
    
    public abstract partial class CmlEntityChildren : CmlElement, CmlEntityInfo
	{
        protected abstract void PushToRepresentationInternal(CmlContext context, object representation, RepresentationInfo info);

        public void PushToRepresentation(CmlContext context, object representation)
        {
            PushToRepresentationInternal(
                context,
                representation,
                context.GetEngine().AssertGetInfo(representation.GetTypeEX(), RepresentationInfo.UnamedChildren)
            );
        }

        public CmlParameter CreateParameter(CmlContext context)
        {
            return new CmlParameter(
                context,
                RepresentationInfo.UnamedChildren,
            );
        }
	}
	
}
