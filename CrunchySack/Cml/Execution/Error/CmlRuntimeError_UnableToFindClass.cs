using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeError_UnableToFindClass : CmlRuntimeErrorException
	{
        public CmlRuntimeError_UnableToFindClass(Type type, string layout) : base("Unable to find the " + layout + " layout cml class for " + type + ".") { }
	}
	
}
