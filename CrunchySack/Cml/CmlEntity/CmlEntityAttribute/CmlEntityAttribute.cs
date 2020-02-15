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
    
    public partial class CmlEntityAttribute : CmlElement
	{
        public void InitializeRepresentation(CmlExecution execution, object representation)
        {
            GetValueSource().SolidifyInto(
                execution,
                execution.GetTargetInfo().GetEngine().AssertCreateInfoContainer(execution, representation, GetName())
            );
        }

        public CmlParameter CreateParameter(CmlExecution execution)
        {
            return new CmlParameter(
                GetName(),
                GetValueSource().CreateDeferred(execution)
            );
        }
	}
	
}
