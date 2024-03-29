
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
    
    public partial class CMinorStatement_IndirectAssign : CMinorStatement
	{
        public override ILStatement Compile(CMinorEnvironment environment)
        {
            return new ILAssign(
                environment.ResolveIndirectIdentifierAsValue(
                    GetCMinorExpression1().CompileAsValue(environment),
                    GetId()
                ),
                GetCMinorExpression2().CompileAsValue(environment)
            );
        }
	}
	
}
