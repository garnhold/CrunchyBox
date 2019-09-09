
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 08 2019 13:32:01 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyRamen
{
	public partial class CMinorStatement_IndirectAssign : CMinorStatement
	{
        public override ILStatement Compile(CMinorEnvironment environment)
        {
            return new ILAssign(
                GetCMinorExpression1().CompileAsValue(environment).GetILProp(GetId()),
                GetCMinorExpression2().CompileAsValue(environment)
            );
        }
	}
	
}
