
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
    
    public class CmlContext_Child_RepresentationSpace : CmlContext_Child
    {
        private CmlRepresentationSpace representation_space;

        public CmlContext_Child_RepresentationSpace(CmlContext p, CmlRepresentationSpace s) : base(p)
        {
            representation_space = s;
        }

        public override CmlRepresentationSpace GetRepresentationSpace()
        {
            return representation_space;
        }
    }

    static public partial class CmlContextExtensions_NewContext
    {
        static public CmlContext NewRepresentationSpace(this CmlContext item)
        {
            return new CmlContext_Child_RepresentationSpace(item, new CmlRepresentationSpace());
        }
    }

}
