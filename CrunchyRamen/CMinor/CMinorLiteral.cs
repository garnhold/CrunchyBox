
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:02:54 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorLiteral : CMinorElement
	{
        public abstract object GetSystemValue();

        public ILValue Compile()
        {
            return ILLiteral.New(GetSystemValue());
        }
	}
	
}
