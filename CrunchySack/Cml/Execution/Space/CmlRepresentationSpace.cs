using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlRepresentationSpace
    {
        private object representation;
        private Dictionary<RepresentationInfoSet, CmlSet> sets;

        public CmlRepresentationSpace(object r)
        {
            representation = r;
            sets = new Dictionary<RepresentationInfoSet, CmlSet>();
        }

        public void SolidifyInstance(CmlContext context)
        {
            sets.Process(p => p.Key.SolidifyInstance(context, representation, p.Value));
        }

        public object GetRepresentation()
        {
            return representation;
        }

        public CmlSet GetSet(RepresentationInfoSet set)
        {
            return sets.GetOrCreateDefaultValue(set);
        }
    }
}
