
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 08 2019 13:32:01 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorStatement_If : CMinorStatement
	{
        public override ILStatement Compile(CMinorEnvironment environment)
        {
            return new ILIf(
                GetCMinorExpression().CompileAsValue(environment),
                GetCMinorStatement1().Compile(environment),
                GetCMinorStatement2().IfNotNull(s => s.Compile(environment))
            );
        }
	}
	
}
