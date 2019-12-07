using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class TypeFilters : IdentifiableEnumerable<Filterer<Type>>
    {
        public TypeFilters(IEnumerable<Filterer<Type>> t) : base(t) { }
    }
}