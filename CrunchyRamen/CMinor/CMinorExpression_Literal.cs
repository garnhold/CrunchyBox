
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:15:13 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorExpression_Literal : CMinorExpression
	{
        public override ILValue CompileAsValue(CMinorEnvironment environment)
        {
            return GetCMinorLiteral().Compile();
        }
	}
	
}
