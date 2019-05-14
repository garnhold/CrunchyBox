using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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
