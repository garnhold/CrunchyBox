using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_InfoSupportException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InfoSupportException(string support_type, RepresentationInfo info) : base("The " + info.GetName() + " attribute of " + info.GetRepresentationType() + " doesn't support " + support_type +".") { }
	}
	
}
