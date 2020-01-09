
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 09 2019 1:05:15 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public partial class CMinorStatement_OperationAssign_IndirectAdditive : CMinorStatement_OperationAssign
	{
        protected override ILValue ResolveDestination(CMinorEnvironment environment)
        {
            return environment.ResolveIndirectIdentifierAsValue(
                GetCMinorExpression1().CompileAsValue(environment),
                GetId()
            );
        }

        public override CMinorBinaryOperator GetCMinorBinaryOperator()
        {
            return GetCMinorBinaryOperatorAdditive();
        }
	}
	
}
