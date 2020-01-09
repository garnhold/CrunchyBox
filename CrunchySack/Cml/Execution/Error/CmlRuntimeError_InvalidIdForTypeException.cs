using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_InvalidIdForTypeException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InvalidIdForTypeException(string for_what, string id, Type type) : base(id + " is an invalid " + for_what + " for " + type + ".") { }
	}
	
}
