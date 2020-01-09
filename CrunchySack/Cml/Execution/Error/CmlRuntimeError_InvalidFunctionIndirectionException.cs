using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_InvalidFunctionIndirectionException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InvalidFunctionIndirectionException(Type type, string id, IEnumerable<Type> parameter_types) : base("The function indirection of " + id + "(" + parameter_types.ToString(", ") + ") is invalid for " + type + ".") { }
	}
	
}
