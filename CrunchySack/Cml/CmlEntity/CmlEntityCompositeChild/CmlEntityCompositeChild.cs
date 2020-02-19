using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlEntityCompositeChild : CmlElement
	{
        public void InitializeRepresentation(CmlContext context, object representation)
        {
            GetComponentSource().SolidifyInto(
                context,
                context.GetEngine().AssertCreateInfoContainer(context, representation, RepresentationInfo.UnamedChildren)
            );
        }
	}
	
}
