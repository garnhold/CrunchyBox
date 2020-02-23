
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
    
    public class CmlContext_Child_FragmentSpace : CmlContext_Child
    {
        private CmlFragmentSpace fragment_space;

        public CmlContext_Child_FragmentSpace(CmlContext p, CmlFragmentSpace s) : base(p)
        {
            fragment_space = s;
        }

        public override CmlFragmentSpace GetFragmentSpace()
        {
            return fragment_space;
        }
    }

    static public partial class CmlContextExtensions_NewContext
    {
        static public CmlContext NewFragmentSpace(this CmlContext item, IEnumerable<CmlParameter> parameters)
        {
            return new CmlContext_Child_FragmentSpace(item, new CmlFragmentSpace(parameters));
        }
    }

}
