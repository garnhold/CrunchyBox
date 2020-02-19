
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
    
    public class CmlContext_Child_Class : CmlContext_Child
    {
        private CmlClass @class;

        public CmlContext_Child_Class(CmlContext p, CmlClass c) : base(p)
        {
            @class = c;
        }

        public override CmlClass GetClass()
        {
            return @class;
        }
	}

    static public partial class CmlContextExtensions_NewContext
    {
        static public CmlContext NewClass(this CmlContext item, CmlClass @class)
        {
            return new CmlContext_Child_Class(item, @class);
        }
    }

}
