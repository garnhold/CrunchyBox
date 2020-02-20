
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
    
    public partial class CmlConstructor : CmlElement
	{
        public object Invoke(CmlContext context)
        {
            return context.GetEngine().AssertInvokeConstructor(
                context, 
                GetName(), 
                GetArgumentSources().Instance(context)
            );
        }
	}
	
}
