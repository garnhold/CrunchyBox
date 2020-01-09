using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class PropertyInfoFilters : IdentifiableEnumerable<Filterer<PropertyInfo>>
    {
        public PropertyInfoFilters(IEnumerable<Filterer<PropertyInfo>> m) : base(m) { }
    }
}