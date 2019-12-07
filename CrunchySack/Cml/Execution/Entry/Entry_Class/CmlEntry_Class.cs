
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
    
    public abstract class CmlEntry_Class : CmlEntry
	{
        private Type target_type;
        private string layout;

        protected abstract void SolidifyIntoInternalClass(CmlExecution execution, CmlContainer container);

        protected override void SolidifyIntoInternal(CmlExecution execution, CmlContainer container)
        {
            execution.PushPopClass(
                this,
                () => SolidifyIntoInternalClass(execution, container)
            );
        }

        public CmlEntry_Class(Type t, string l)
        {
            target_type = t;
            layout = l;
        }

        public object CreateRepresentation(CmlExecution execution)
        {
            CmlContainer container = new CmlContainer_Value();

            SolidifyInto(execution, container);
            return container.ForceContainedSystemValue();
        }

        public RepresentationResult CreateRepresentationGetResult(CmlExecution execution)
        {
            return new RepresentationResult(CreateRepresentation(execution), execution);
        }

        public Type GetTargetType()
        {
            return target_type;
        }

        public string GetLayout()
        {
            return layout;
        }
	}
	
}
