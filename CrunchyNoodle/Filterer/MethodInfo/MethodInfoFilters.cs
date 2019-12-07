using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class MethodInfoFilters : IdentifiableEnumerable<Filterer<MethodInfo>>
    {
        public MethodInfoFilters(IEnumerable<Filterer<MethodInfo>> m) : base(m) { }
    }
}