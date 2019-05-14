
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
	public abstract partial class CmlPrimitive : CmlElement
	{
        public abstract object GetSystemValue();

        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            container.Insert(
                execution,
                new CmlValue_SystemValue(GetSystemValue())
            );
        }
	}
	
}
