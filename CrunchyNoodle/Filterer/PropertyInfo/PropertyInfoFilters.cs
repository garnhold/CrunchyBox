using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class PropertyInfoFilters : IdentifiableEnumerable<Filterer<PropertyInfo>>
    {
        public PropertyInfoFilters(IEnumerable<Filterer<PropertyInfo>> m) : base(m) { }
    }
}