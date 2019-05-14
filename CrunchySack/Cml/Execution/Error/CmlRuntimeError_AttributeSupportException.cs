using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeError_AttributeSupportException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_AttributeSupportException(string support_type, RepresentationInfo_Attribute attribute) : base("The " + attribute.GetName() + " attribute of " + attribute.GetRepresentationType() + " doesn't support " + support_type +".") { }
	}
	
}
