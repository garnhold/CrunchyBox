
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 21:52:01 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public partial class CmlInsertParameter : CmlElement
	{
        public void SolidifyInto(CmlExecution execution, CmlContainer container, bool assert)
        {
            execution.GetCallContext().GetParameterSpace().IfNotNull(s => s.GetParameter(GetId())).IfNotNull(
                p => p.SolidifyInto(execution, container),
                () => GetDefaultValueSource().IfNotNull(
                    v => v.SolidifyInto(execution, container),
                    () => assert.ThrowIfTrue(() => new CmlRuntimeError_InvalidIdException("parameter", GetId()))
                )
            );
        }
	}
	
}
