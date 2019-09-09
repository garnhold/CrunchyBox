
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 07 2019 0:36:17 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyRamen
{
	public partial class CMinorExpression_IndirectIdentifier : CMinorExpression
	{
        public override ILValue CompileAsValue(CMinorEnvironment environment)
        {
            return GetCMinorExpression()
                .CompileAsValue(environment)
                .GetILProp(GetId());
        }

        public override ILValue CompileAsInvokation(CMinorEnvironment environment, IEnumerable<ILValue> arguments)
        {
            return GetCMinorExpression()
                .CompileAsValue(environment)
                .GetILInvoke(GetId(), arguments);
        }

        public override ILValue CompileAsGenericInvokation(CMinorEnvironment environment, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return GetCMinorExpression()
                .CompileAsValue(environment)
                .GetILGenericInvoke(GetId(), generic_arguments, arguments);
        }
	}
	
}
