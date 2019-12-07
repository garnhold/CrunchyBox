using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class AssemblyFilters : IdentifiableEnumerable<Filterer<Assembly>>
    {
        public AssemblyFilters(IEnumerable<Filterer<Assembly>> a) : base(a) { }
    }
}