using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeError_TypeSupportException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_TypeSupportException(string support_type, CmlValue value) : base(value.GetType() + " value do not support " + support_type + ".") { }
	}
	
}
