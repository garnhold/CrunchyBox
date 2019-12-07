using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_TypeSupportException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_TypeSupportException(string support_type, CmlValue value) : base(value.GetType() + " value do not support " + support_type + ".") { }
	}
	
}
