
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 29 2019 16:05:57 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCheese
{
	public partial class MExpExpression_Sign : MExpExpression
	{
        public override ILValue GetILValue()
        {
            return GetMExpExpression().GetILValue()
                .GetILUnaryOperatorInvokation(GetMExpUnarySignOperator().GetUnaryOperatorType());
        }
	}
	
}
