
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 07 2019 15:08:56 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorExpression_InvokeGeneric : CMinorExpression
	{
        public override ILValue CompileAsValue(CMinorEnvironment environment)
        {
            return GetCMinorExpression().CompileAsGenericInvokation(
                environment,
                GetCMinorTypeList().GetSystemTypes(environment),
                GetCMinorExpressionList().IfNotNull(l => l.CompileAsValues(environment))
            );
        }
	}
	
}
