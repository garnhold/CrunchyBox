using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class ConstructorInfoFilters : IdentifiableEnumerable<Filterer<ConstructorInfo>>
    {
        public ConstructorInfoFilters(IEnumerable<Filterer<ConstructorInfo>> c) : base(c) { }
    }
}