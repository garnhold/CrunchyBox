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
    
    public partial class CmlEntity : CmlElement
	{
        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            execution.GetTargetInfo().GetEngine().AssertEntityInstance(execution, this, GetTag())
                .SolidifyInto(execution, container);
        }

        public bool HasId()
        {
            if (GetId().IsVisible())
                return true;

            return false;
        }
	}
	
}
