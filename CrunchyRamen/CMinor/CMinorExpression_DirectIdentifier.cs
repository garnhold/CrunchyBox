
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 07 2019 0:36:17 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorExpression_DirectIdentifier : CMinorExpression
	{
        public override ILValue CompileAsValue(CMinorEnvironment environment)
        {
            return environment.ResolveDirectIdentifierAsValue(GetId());
        }

        public override ILValue CompileAsIndexed(CMinorEnvironment environment, ILValue index)
        {
            return environment.ResolveDirectIdentifierAsIndexed(GetId(), index);
        }

        public override ILValue CompileAsInvokation(CMinorEnvironment environment, IEnumerable<ILValue> arguments)
        {
            return environment.ResolveDirectIdentifierAsInvokation(GetId(), arguments);
        }

        public override ILValue CompileAsGenericInvokation(CMinorEnvironment environment, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return environment.ResolveDirectIdentifierAsGenericInvokation(GetId(), generic_arguments, arguments);
        }
	}
	
}
