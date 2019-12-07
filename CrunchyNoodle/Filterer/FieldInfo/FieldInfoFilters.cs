using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class FieldInfoFilters : IdentifiableEnumerable<Filterer<FieldInfo>>
    {
        public FieldInfoFilters(IEnumerable<Filterer<FieldInfo>> f) : base(f) { }
    }
}