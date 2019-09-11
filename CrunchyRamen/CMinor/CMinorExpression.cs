
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:02:54 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyRamen
{
	public partial class CMinorExpression : CMinorElement
	{
        public abstract ILValue CompileAsValue(CMinorEnvironment environment);

        public virtual ILValue CompileAsInvokation(CMinorEnvironment environment, IEnumerable<ILValue> arguments)
        {
            return CompileAsValue(environment).GetILInvokeSelf(arguments);
        }

        public virtual ILValue CompileAsGenericInvokation(CMinorEnvironment environment, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            throw new InvalidOperationException(GetType() + " doesn't support generic invokation.");
        }
	}
	
}
