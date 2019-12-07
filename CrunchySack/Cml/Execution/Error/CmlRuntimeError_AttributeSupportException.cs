using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlRuntimeError_AttributeSupportException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_AttributeSupportException(string support_type, RepresentationInfo_Attribute attribute) : base("The " + attribute.GetName() + " attribute of " + attribute.GetRepresentationType() + " doesn't support " + support_type +".") { }
	}
	
}
