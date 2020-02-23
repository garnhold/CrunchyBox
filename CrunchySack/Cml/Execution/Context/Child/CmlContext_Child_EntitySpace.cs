using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    public class CmlContext_Child_EntitySpace : CmlContext_Child
    {
        private CmlEntitySpace set_space;

        public CmlContext_Child_EntitySpace(CmlContext p, CmlEntitySpace s) : base(p)
        {
            set_space = s;
        }

        public override CmlEntitySpace GetEntitySpace()
        {
            return set_space;
        }
    }

    static public partial class CmlContextExtensions_NewContext
    {
        static public CmlContext NewEntitySpace(this CmlContext item, object representation, out CmlEntitySpace entity_space)
        {
            entity_space = new CmlEntitySpace(representation);

            return new CmlContext_Child_EntitySpace(item, entity_space);
        }
    }
	
}
