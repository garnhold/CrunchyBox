using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class MethodInfoFilters : IdentifiableEnumerable<Filterer<MethodInfo>>
    {
        public MethodInfoFilters(IEnumerable<Filterer<MethodInfo>> m) : base(m) { }
    }
}