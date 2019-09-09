
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 08 2019 2:08:54 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	public partial class CMinorExpression_This : CMinorExpression
	{
        public override ILValue CompileAsValue(CMinorEnvironment environment)
        {
            return environment.ResolveThis();
        }
	}
	
}
