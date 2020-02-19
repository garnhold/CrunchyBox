
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
    
    public class CmlContext_Child_SetSpace : CmlContext_Child
    {
        private CmlSetSpace set_space;

        public CmlContext_Child_SetSpace(CmlContext p, CmlSetSpace s) : base(p)
        {
            set_space = s;
        }

        public override CmlSetSpace GetSetSpace()
        {
            return set_space;
        }
    }

    static public partial class CmlContextExtensions_NewContext
    {
        static public CmlContext NewSetSpace(this CmlContext item, out CmlSetSpace set_space)
        {
            set_space = new CmlSetSpace();

            return new CmlContext_Child_SetSpace(item, set_space);
        }
    }
	
}
