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

        public void SolidifyInstance(CmlExecution execution, object representation)
        {
            sets.Process(p => p.Key.SolidifyInstance(execution, representation, p.Value));
        }

        public CmlSet GetSet(RepresentationInfoSet set)
        {
            return sets.GetOrCreateDefaultValue(set);
        }
    }
}
