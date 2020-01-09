
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
    
    public abstract class CMinorStatement_OperationAssign : CMinorStatement
	{
        public abstract CMinorExpression GetAssignmentExpression();
        public abstract CMinorBinaryOperator GetCMinorBinaryOperator();

        protected abstract ILValue ResolveDestination(CMinorEnvironment environment);

        public override ILStatement Compile(CMinorEnvironment environment)
        {
            ILValue dst = ResolveDestination(environment);

            return new ILAssign(
                dst,
                dst.GetILBinaryOperatorInvokation(
                    GetCMinorBinaryOperator().GetBinaryOperatorType(),
                    GetAssignmentExpression().CompileAsValue(environment)
                )
            );
        }
	}
	
}
