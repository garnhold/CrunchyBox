
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 16 2018 12:44:50 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public abstract class CmlEntry_Fragment : CmlEntry
	{
        public abstract string GetName();

        protected abstract void SolidifyIntoInternalFragment(CmlExecution execution, CmlContainer container);

        protected override void SolidifyIntoInternal(CmlExecution execution, CmlContainer container)
        {
            SolidifyIntoInternalFragment(execution, container);
        }
	}
	
}
