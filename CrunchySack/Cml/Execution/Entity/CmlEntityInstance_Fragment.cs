
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class CmlEntityInstance_Fragment : CmlEntityInstance
	{
        private CmlEntry_Fragment fragment;

        protected override void SolidifyInternal(CmlExecution execution, CmlContainer container)
        {
            List<CmlParameter> parameters = GetEntity().GetAttributes().Convert(a => a.CreateParameter(execution)).ToList();

            execution.PushPopParameterSpace(
                parameters,
                () => fragment.SolidifyInto(execution, container)
            );

            object representation = GetRepresentation();

            parameters.Narrow(p => p.IsUnused()).Process(p => p.ApplyAsAttribute(execution, representation));
        }

        public CmlEntityInstance_Fragment(CmlEntity e, CmlEntry_Fragment f) : base(e)
        {
            fragment = f;
        }
	}
	
}
