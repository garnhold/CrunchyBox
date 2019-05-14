
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public abstract class CmlContainer_EndPoint : CmlContainer
	{
        private void InsertInternal(CmlValue value, CmlExecution execution)
        {
            throw new CmlRuntimeError_ContainerSupportException(this, value.GetType());
        }

        protected override void InsertInternal(CmlExecution execution, CmlValue value)
        {
            this.CallSpecializationMethod<CmlValue, CmlExecution>("InsertInternal", value, execution);
        }
	}
}
