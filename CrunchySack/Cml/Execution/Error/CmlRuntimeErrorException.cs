using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeErrorException : Exception
	{
        public CmlRuntimeErrorException(string error) : base(error) { }
	}
	
}
