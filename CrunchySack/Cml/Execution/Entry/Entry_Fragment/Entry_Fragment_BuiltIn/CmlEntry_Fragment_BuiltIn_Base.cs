using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlEntry_Fragment_BuiltIn_Base : CmlEntry_Fragment_BuiltIn
	{
        protected override void SolidifyIntoInternalFragment(CmlExecution execution, CmlContainer container)
        {
            CmlEntry_Class @class = execution.GetCallContext().GetClass();

            execution.GetTargetInfo().GetEngine().GetClassLibrary().GetClass(@class.GetTargetType().BaseType, @class.GetLayout())
                .IfNotNull(c => c.SolidifyInto(execution, container));
        }

        public CmlEntry_Fragment_BuiltIn_Base() : base("Base") { }
	}
	
}
