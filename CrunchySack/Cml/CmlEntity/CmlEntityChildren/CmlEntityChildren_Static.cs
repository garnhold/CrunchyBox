
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
        protected override void PushToRepresentationInternal(CmlContext context, object representation, RepresentationInfo info)
        {
            info.SetMultipleValues(
                context,
                representation,
                GetComponentSourceList().GetComponentSources().Convert(s => s.Instance(context))
            );
        }
    }
	
}
