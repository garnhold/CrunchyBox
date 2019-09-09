
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 09 2019 1:05:15 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyRamen
{
	public partial class CMinorStatement_OperationAssign_IndirectAdditive : CMinorStatement_OperationAssign
	{
        protected override ILValue ResolveDestination(CMinorEnvironment environment)
        {
            return GetCMinorExpression1()
                .CompileAsValue(environment)
                .GetILProp(GetId());
        }

        public override CMinorBinaryOperator GetCMinorBinaryOperator()
        {
            return GetCMinorBinaryOperatorAdditive();
        }
	}
	
}
