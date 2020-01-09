
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 29 2019 15:40:47 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cheese
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class MExpExpression_Additive : MExpExpression
	{
        public override ILValue GetILValue()
        {
            return GetMExpExpression1().GetILValue()
                .GetILBinaryOperatorInvokation(
                    GetMExpBinaryAdditiveOperator().GetBinaryOperatorType(),
                    GetMExpExpression2().GetILValue()
                );
        }
	}
	
}
