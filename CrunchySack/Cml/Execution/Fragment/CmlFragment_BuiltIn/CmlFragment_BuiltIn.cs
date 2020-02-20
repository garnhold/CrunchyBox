using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class CmlFragment_BuiltIn : CmlFragment
	{
        private string name;

        public CmlFragment_BuiltIn(string n)
        {
            name = n;
        }

        public override string GetName()
        {
            return name;
        }
	}
	
}
