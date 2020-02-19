
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 22:31:32 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlClass_None : CmlClass
	{
        protected override object InstanceInternal(CmlContext context)
        {
            return context.GetTargetInfo().GetTarget();
        }

        public CmlClass_None(Type t) : base(t, "none")
        {
        }
	}
	
}
