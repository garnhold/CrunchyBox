using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeError_InvalidIdException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_InvalidIdException(string for_what, string id) : base(id + " is an invalid " + for_what + ".") { }
	}
	
}
