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
        public object Instance(CmlContext context)
        {
            return context.GetEngine().AssertInstanceEntity(context, GetTag(), this);
        }

        public bool HasId()
        {
            if (GetId().IsVisible())
                return true;

            return false;
        }
	}
	
}
