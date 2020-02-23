
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 16 2018 12:44:50 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class CmlFragment : CmlEntityInstancer
	{
        protected abstract object InstanceInternal(CmlContext context);

        public abstract string GetName();

        public object Instance(CmlContext context, CmlEntity entity)
        {
            List<CmlParameter> parameters = entity.GetTopicalChildren<CmlEntityInfo>()
                .Convert(i => i.CreateParameter(context))
                .ToList();

            object representation = InstanceInternal(
                context
                    .NewParameterSpace(parameters)
                    .NewRepresentationSpace()
            );

            parameters.Narrow(p => p.IsUnused()).Process(p => p.PushToRepresentation(context, representation));
            return representation;
        }
	}
	
}
