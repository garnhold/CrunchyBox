using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlSetSpace
    {
        private Dictionary<RepresentationInfoSet, CmlSet> sets;

        public CmlSetSpace()
        {
            sets = new Dictionary<RepresentationInfoSet, CmlSet>();
        }

        public void SolidifyInstance(CmlContext context, object representation)
        {
            sets.Process(p => p.Key.SolidifyInstance(context, representation, p.Value));
        }

        public CmlSet GetSet(RepresentationInfoSet set)
        {
            return sets.GetOrCreateDefaultValue(set);
        }
    }
}
