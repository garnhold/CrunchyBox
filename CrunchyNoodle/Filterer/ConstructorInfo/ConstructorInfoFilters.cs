using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class ConstructorInfoFilters : IdentifiableEnumerable<Filterer<ConstructorInfo>>
    {
        public ConstructorInfoFilters(IEnumerable<Filterer<ConstructorInfo>> c) : base(c) { }
    }
}