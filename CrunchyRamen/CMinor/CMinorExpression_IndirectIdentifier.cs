
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
            return environment.ResolveIndirectIdentifierAsValue(
                GetCMinorExpression().CompileAsValue(environment),
                GetId()
            );
        }

        public override ILValue CompileAsIndexed(CMinorEnvironment environment, ILValue index)
        {
            return environment.ResolveIndirectIdentifierAsIndexed(
                GetCMinorExpression().CompileAsValue(environment),
                GetId(),
                index
            );
        }

        public override ILValue CompileAsInvokation(CMinorEnvironment environment, IEnumerable<ILValue> arguments)
        {
            return environment.ResolveIndirectIdentifierAsInvokation(
                GetCMinorExpression().CompileAsValue(environment),
                GetId(),
                arguments
            );
        }

        public override ILValue CompileAsGenericInvokation(CMinorEnvironment environment, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return environment.ResolveIndirectIdentifierAsGenericInvokation(
                GetCMinorExpression().CompileAsValue(environment),
                GetId(),
                generic_arguments,
                arguments
            );
        }
	}
	
}
