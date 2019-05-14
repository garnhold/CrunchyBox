using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeError_InvalidFunctionIndirectionException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InvalidFunctionIndirectionException(Type type, string id, IEnumerable<Type> parameter_types) : base("The function indirection of " + id + "(" + parameter_types.ToString(", ") + ") is invalid for " + type + ".") { }
	}
	
}
