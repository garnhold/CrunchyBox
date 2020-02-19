using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_UnexpectedInsertParameterTypeException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_UnexpectedInsertParameterTypeException(Type expected, string name) : base("The insert parameter " + name + " is expected to a " + expected + ".") { }
	}
	
}
