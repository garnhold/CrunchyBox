
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlEntityInstance_Normal : CmlEntityInstance
	{
        private RepresentationInstancer instancer;

        protected override object SolidifyInternal(CmlExecution execution, CmlContainer container)
        {
            container.Insert(
                execution,
                new CmlValue_SystemValue(instancer.Instance(execution))
            );

            object representation = container.ForceContainedSystemValue();

            execution.GetTargetInfo().GetEngine().AssertApplyGeneralModifiers(execution, representation);
            GetEntity().GetAttributes().Process(a => a.InitializeRepresentation(execution, representation));

            return representation;
        }

        public CmlEntityInstance_Normal(CmlEntity e, RepresentationInstancer i) : base(e)
        {
            instancer = i;
        }
	}
	
}
