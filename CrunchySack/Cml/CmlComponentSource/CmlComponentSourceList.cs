
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
	public partial class CmlComponentSourceList : CmlElement
	{
        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            container.Insert(
                execution,
                new CmlValue_ComponentSourceList(this)
            );
        }
	}
	
}
