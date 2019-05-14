using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public partial class Types
    {
         static private CompileTimeCache<List<Type>, TypeFilters> GET_FILTERED_TYPES = ReflectionCache.Get().NewCompileTimeCache("GET_FILTERED_TYPES", TypeListHusker.INSTANCE, delegate(TypeFilters filters) {
            return GetAllTypesFromFilteredAssemblys(filters.GetAssemblyFilters())
                .FilterBy(filters)
                .ToList();
        });
        static public IEnumerable<Type> GetFilteredTypes(IEnumerable<Filterer<Type>> filters)
        {
            return GET_FILTERED_TYPES.Fetch(new TypeFilters(filters));
        }
        static public IEnumerable<Type> GetFilteredTypes(params Filterer<Type>[] filters)
        {
            return GetFilteredTypes((IEnumerable<Filterer<Type>>)filters);
        }
    }
}