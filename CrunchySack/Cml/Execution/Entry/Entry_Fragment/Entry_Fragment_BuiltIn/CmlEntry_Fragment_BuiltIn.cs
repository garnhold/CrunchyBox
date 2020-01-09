using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class CmlEntry_Fragment_BuiltIn : CmlEntry_Fragment
	{
        private string name;

        public CmlEntry_Fragment_BuiltIn(string n)
        {
            name = n;
        }

        public override string GetName()
        {
            return name;
        }
	}
	
}
