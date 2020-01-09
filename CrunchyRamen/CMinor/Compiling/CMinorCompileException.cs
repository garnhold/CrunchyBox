using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CMinorCompileException : Exception
	{
        public CMinorCompileException(string m) : base(m) { }
	}
	
}
