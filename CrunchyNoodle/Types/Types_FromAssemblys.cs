using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public partial class Types
    {
        static private OperationCache<List<Type>, AssemblyFilters> GET_ALL_TYPES_FROM_FILTERED_ASSEMBLYS = ReflectionCache.Get().NewOperationCache(delegate(AssemblyFilters filters) {
            return Assemblys.GetFilteredAssemblys(filters)
                .Convert(a => a.GetAllDefinedTypes())
                .Append(GetAllPrimitiveTypes())
                .Unique()
                .ToList();
        });
        static public IEnumerable<Type> GetAllTypesFromFilteredAssemblys(IEnumerable<Filterer<Assembly>> filters)
        {
            return GET_ALL_TYPES_FROM_FILTERED_ASSEMBLYS.Fetch(new AssemblyFilters(filters));
        }
        static public IEnumerable<Type> GetAllTypesFromFilteredAssemblys(params Filterer<Assembly>[] filters)
        {
            return GetAllTypesFromFilteredAssemblys((IEnumerable<Filterer<Assembly>>)filters);
        }
    }
}