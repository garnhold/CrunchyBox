
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
    
    public partial class CmlEntityChildren_Dynamic : CmlEntityChildren
	{
        protected override void PushToRepresentationInternal(CmlContext context, object representation, RepresentationInfo info)
        {
            CmlValue_Link link = GetLinkSource().SolidifyLink(context);

            info.LinkValue(
                context,
                representation,
                link.GetVariableInstance(),
                link
            );
        }
    }
	
}
