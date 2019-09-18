
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

namespace CrunchyRamen
{
	public partial class CMinorStatement_OperationAssign_DirectMultiplicative : CMinorStatement_OperationAssign
	{
        protected override ILValue ResolveDestination(CMinorEnvironment environment)
        {
            return environment.ResolveDirectIdentifierAsValue(GetId());
        }

        public override CMinorBinaryOperator GetCMinorBinaryOperator()
        {
            return GetCMinorBinaryOperatorMultiplicative();
        }
	}
	
}
