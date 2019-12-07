using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeErrorException : Exception
	{
        public CmlRuntimeErrorException(string error) : base(error) { }
	}
	
}
