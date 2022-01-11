
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:02:54 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorExpression : CMinorElement
	{
        public abstract ILValue CompileAsValue(CMinorEnvironment environment);

        public virtual ILValue CompileAsIndexed(CMinorEnvironment environment, ILValue index)
        {
            return CompileAsValue(environment).GetILIndexed(index);
        }

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
