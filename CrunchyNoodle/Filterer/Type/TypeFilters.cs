using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class TypeFilters : IdentifiableEnumerable<Filterer<Type>>
    {
        public TypeFilters(IEnumerable<Filterer<Type>> t) : base(t) { }
    }
}