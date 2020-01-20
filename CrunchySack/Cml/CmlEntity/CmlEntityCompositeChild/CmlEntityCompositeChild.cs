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
        public void InitializeRepresentation(CmlExecution execution, object representation)
        {
            GetComponentSource().SolidifyInto(
                execution,
                execution.GetTargetInfo().GetEngine().AssertCreateChildrenContainer(execution, representation)
            );
        }
	}
	
}
