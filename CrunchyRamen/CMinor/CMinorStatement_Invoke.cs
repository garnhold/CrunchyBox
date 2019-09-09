
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

namespace CrunchyRamen
{
	public partial class CMinorStatement_Invoke : CMinorStatement
	{
        public override ILStatement Compile(CMinorEnvironment environment)
        {
            return GetCMinorExpression().CompileAsInvokation(
                environment,
                GetCMinorExpressionList().IfNotNull(l => l.CompileAsValues(environment))
            ).CreateILCalculate();
        }
	}
	
}
