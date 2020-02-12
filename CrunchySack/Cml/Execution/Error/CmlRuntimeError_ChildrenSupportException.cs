using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_ChildrenSupportException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_ChildrenSupportException(string support_type, RepresentationInfo_Children children) : base("The children of " + children.GetRepresentationType() + " doesn't support " + support_type +".") { }
	}
	
}
