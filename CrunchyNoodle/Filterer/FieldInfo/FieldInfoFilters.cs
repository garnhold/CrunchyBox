using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class FieldInfoFilters : IdentifiableEnumerable<Filterer<FieldInfo>>
    {
        public FieldInfoFilters(IEnumerable<Filterer<FieldInfo>> f) : base(f) { }
    }
}