using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlEntry_Fragment_BuiltIn_Layout : CmlEntry_Fragment_BuiltIn
	{
        protected override void SolidifyIntoInternalFragment(CmlExecution execution, CmlContainer container)
        {
            Type type = execution.GetCallContext().GetClass().GetTargetType();
            string layout = execution.GetCallContext().GetParameterSpace().GetParameterForcedSystemValue<string>(execution, "name");

            execution.GetTargetInfo().GetEngine().GetClassLibrary().GetClass(type, layout)
                .IfNotNull(c => c.SolidifyInto(execution, container));
        }

        public CmlEntry_Fragment_BuiltIn_Layout() : base("Layout") { }
	}
	
}
