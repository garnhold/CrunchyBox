
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
    
    public class CmlEntityInstance_Fragment : CmlEntityInstance
	{
        private CmlEntry_Fragment fragment;

        protected override object SolidifyInternal(CmlExecution execution, CmlContainer container)
        {
            object mount_point = null;
            List<CmlParameter> parameters = GetEntity().GetAttributes().Convert(a => a.CreateParameter(execution)).ToList();

            execution.PushPopReturnSpaceNew(delegate (CmlReturnSpace return_space) {
                return_space.RequestSystemValueReturn("MOUNT_POINT", v => mount_point = v);

                execution.PushPopParameterSpaceNew(
                    parameters,
                    () => fragment.SolidifyInto(execution, container)
                );
            });

            object representation = container.ForceContainedSystemValue();

            parameters.Narrow(p => p.IsUnused()).Process(p => p.ApplyAsAttribute(execution, representation));
            return mount_point ?? representation;
        }

        public CmlEntityInstance_Fragment(CmlEntity e, CmlEntry_Fragment f) : base(e)
        {
            fragment = f;
        }
	}
	
}
