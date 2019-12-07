using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_InvalidTypeException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InvalidTypeException(string for_what, Type type) : base(for_what + " is invalid for " + type + ".") { }
	}
	
}
