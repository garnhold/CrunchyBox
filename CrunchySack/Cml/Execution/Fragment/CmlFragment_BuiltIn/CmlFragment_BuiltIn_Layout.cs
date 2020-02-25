using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlFragment_BuiltIn_Layout : CmlFragment_BuiltIn
	{
        protected override object InstanceInternal(CmlContext context)
        {
            Type type = context.GetClass().GetTargetType();
            string layout = context.GetFragmentSpace().GetParameterForcedSystemValue<string>(context, "name");

            return context.GetEngine().GetClassLibrary().GetClass(type, layout)
                .IfNotNull(c => c.Create(context));
        }

        public CmlFragment_BuiltIn_Layout() : base("Layout") { }
	}
	
}
