
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
    
    public abstract partial class CmlValueSource : CmlElement
	{
        public abstract object Instance(CmlContext context);

        public abstract void PushToRepresentation(CmlContext context, object representation, RepresentationInfo info);
	}
	
}
