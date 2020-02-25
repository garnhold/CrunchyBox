using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlFragment_BuiltIn_Base : CmlFragment_BuiltIn
	{
        protected override object InstanceInternal(CmlContext context)
        {
            CmlClass @class = context.GetClass();

            return context.GetEngine().GetClassLibrary().GetClass(@class.GetTargetType().BaseType, @class.GetLayout())
                .IfNotNull(c => c.Create(context));
        }

        public CmlFragment_BuiltIn_Base() : base("Base") { }
	}
	
}
