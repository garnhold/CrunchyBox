
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 29 2019 15:40:47 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCheese
{
	public partial class MExpExpression_Multiplicative : MExpExpression
	{
        public override ILValue GetILValue()
        {
            return GetMExpExpression1().GetILValue()
                .GetILBinaryOperatorInvokation(
                    GetMExpBinaryMultiplicativeOperator().GetBinaryOperatorType(),
                    GetMExpExpression2().GetILValue()
                );
        }
	}
	
}
