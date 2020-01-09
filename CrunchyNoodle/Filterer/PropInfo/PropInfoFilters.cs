using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class PropInfoFilters : IdentifiableEnumerable<Filterer<PropInfoEX>>
    {
        public PropInfoFilters(IEnumerable<Filterer<PropInfoEX>> f) : base(f) { }
    }
}