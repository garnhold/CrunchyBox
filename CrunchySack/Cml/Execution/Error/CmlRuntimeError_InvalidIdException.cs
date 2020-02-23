using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_InvalidIdException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InvalidIdException(string for_what, string id) : base(id + " is an invalid " + for_what + " id.") { }
	}
	
}
