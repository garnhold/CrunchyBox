
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 22:55:10 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlComponentSource_Constructor : CmlComponentSource
	{
        public override object Instance(CmlContext context)
        {
            return GetConstructor().Invoke(context);
        }
	}
	
}
