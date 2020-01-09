
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 22:55:10 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlConstructor : CmlElement
	{
        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            CmlContainer_Values values = new CmlContainer_Values();

            GetArgumentSources().SolidifyInto(execution, values);
            execution.GetTargetInfo().GetEngine().AssertConstructorInto(execution, GetName(), values.ForceSystemValues(), container);
        }
	}
	
}
