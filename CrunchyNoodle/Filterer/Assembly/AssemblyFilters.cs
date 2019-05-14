using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class AssemblyFilters : IdentifiableEnumerable<Filterer<Assembly>>
    {
        public AssemblyFilters(IEnumerable<Filterer<Assembly>> a) : base(a) { }
    }
}