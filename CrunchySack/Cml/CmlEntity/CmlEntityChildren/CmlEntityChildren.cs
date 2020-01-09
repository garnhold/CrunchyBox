
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
    
    public abstract partial class CmlEntityChildren : CmlElement
	{
        public abstract void SolidifyInto(CmlExecution execution, CmlContainer container);

        public void InitializeRepresentation(CmlExecution execution, object representation)
        {
            SolidifyInto(
                execution,
                execution.GetTargetInfo().GetEngine().AssertCreateChildrenContainer(execution, representation)
            );
        }
	}
	
}
