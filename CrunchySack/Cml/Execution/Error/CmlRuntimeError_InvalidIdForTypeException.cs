using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeError_InvalidIdForTypeException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InvalidIdForTypeException(string for_what, string id, Type type) : base(id + " is an invalid " + for_what + " for " + type + ".") { }
	}
	
}
