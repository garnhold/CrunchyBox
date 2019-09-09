
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:02:54 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	public partial class CMinorLiteral : CMinorElement
	{
        public abstract object GetSystemValue();

        public ILValue Compile()
        {
            return ILLiteral.New(GetSystemValue());
        }
	}
	
}
