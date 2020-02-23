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
        static public CmlContext NewRepresentationSpace(this CmlContext item, object representation, out CmlRepresentationSpace representation_space)
        {
            representation_space = new CmlRepresentationSpace(representation);

            return new CmlContext_Child_RepresentationSpace(item, representation_space);
        }
    }
	
}
