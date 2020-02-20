
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlParameter : CmlEntityInfo
	{
        private string name;
        private CmlValue value;

        private bool is_used;

        public CmlParameter(string n, CmlValue v)
        {
            name = n;
            value = v;
        }

        public CmlValue Solidify()
        {
            is_used = true;

            return value;
        }
        public CmlValue Solidify(CmlContext context)
        {
            return Solidify();
        }

        public string GetName()
        {
            return name;
        }

        public bool IsUsed()
        {
            return is_used;
        }

        public bool IsUnused()
        {
            if (IsUsed() == false)
                return true;

            return false;
        }
	}
	
}
