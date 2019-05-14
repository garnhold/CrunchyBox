using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRuntimeError_ContainerSupportException : CmlRuntimeErrorException
	{
        public CmlRuntimeError_ContainerSupportException(CmlContainer container, Type support_type) : base(container.GetType() + " containers do not support " + support_type + ".") { }
	}
	
}
