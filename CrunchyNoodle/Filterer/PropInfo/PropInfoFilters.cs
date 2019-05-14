using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class PropInfoFilters : IdentifiableEnumerable<Filterer<PropInfoEX>>
    {
        public PropInfoFilters(IEnumerable<Filterer<PropInfoEX>> f) : base(f) { }
    }
}