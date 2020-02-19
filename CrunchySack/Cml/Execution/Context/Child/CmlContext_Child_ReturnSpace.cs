
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
    
    public class CmlContext_Child_ReturnSpace : CmlContext_Child
    {
        private CmlReturnSpace return_space;

        public CmlContext_Child_ReturnSpace(CmlContext p, CmlReturnSpace r) : base(p)
        {
            return_space = r;
        }

        public override CmlReturnSpace GetReturnSpace()
        {
            return return_space;
        }
    }

    static public partial class CmlContextExtensions_NewContext
    {
        static public CmlContext NewReturnSpace(this CmlContext item, out CmlReturnSpace return_space)
        {
            return_space = new CmlReturnSpace();

            return new CmlContext_Child_ReturnSpace(item, return_space);
        }
    }

}
