using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_UnableToFindClassException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_UnableToFindClassException(Type type, string layout) : base("Unable to find the " + layout + " layout cml class for " + type + ".") { }
	}
	
}
