using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class CMinorExpression_BinaryOperation : CMinorExpression
	{
        public abstract CMinorExpression GetCMinorExpression1();
        public abstract CMinorExpression GetCMinorExpression2();

        public abstract CMinorBinaryOperator GetCMinorBinaryOperator();

        public override ILValue CompileAsValue(CMinorEnvironment environment)
        {
            return GetCMinorExpression1().CompileAsValue(environment).GetILBinaryOperatorInvokation(
                GetCMinorBinaryOperator().GetBinaryOperatorType(),
                GetCMinorExpression2().CompileAsValue(environment)
            );
        }

        
	}
	
}
