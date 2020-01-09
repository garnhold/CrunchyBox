using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_ContainerSupportException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_ContainerSupportException(CmlContainer container, Type support_type) : base(container.GetType() + " containers do not support " + support_type + ".") { }
	}
	
}
