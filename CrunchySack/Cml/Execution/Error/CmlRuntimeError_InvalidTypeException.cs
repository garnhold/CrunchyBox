using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeError_InvalidTypeException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InvalidTypeException(string for_what, Type type) : base(for_what + " is invalid for " + type + ".") { }
	}
	
}
