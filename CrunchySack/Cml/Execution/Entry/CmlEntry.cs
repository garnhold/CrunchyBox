
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 22:43:43 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public abstract class CmlEntry
	{
        protected abstract void SolidifyIntoInternal(CmlExecution execution, CmlContainer container);

        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            execution.PushPopRepresentationSpaceNew(delegate() {
                SolidifyIntoInternal(execution, container);
            });
        }
	}
	
}
