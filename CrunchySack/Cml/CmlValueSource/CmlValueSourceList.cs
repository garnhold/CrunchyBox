
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 22:26:50 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public partial class CmlValueSourceList : CmlElement
	{
        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            GetValueSources().Process(v => v.SolidifyInto(execution, container));
        }
	}
	
}
