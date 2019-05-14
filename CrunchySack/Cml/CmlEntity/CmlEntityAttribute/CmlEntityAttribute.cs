//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 1/30/2017 1:49:45 AM


using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public partial class CmlEntityAttribute : CmlElement
	{
        public void InitializeRepresentation(CmlExecution execution, object representation)
        {
            GetValueSource().SolidifyInto(
                execution,
                execution.GetTargetInfo().GetEngine().AssertCreateAttributeContainer(execution, representation, GetName())
            );
        }

        public CmlParameter CreateParameter(CmlExecution execution)
        {
            return new CmlParameter(
                GetName(),
                GetValueSource().CreateDeferred(execution)
            );
        }
	}
	
}
