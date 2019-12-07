using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public partial class Types
    {
        static private OperationCache<List<Type>, AssemblyFilters> GET_ALL_TYPES_FROM_FILTERED_ASSEMBLYS = ReflectionCache.Get().NewOperationCache("GET_ALL_TYPES_FROM_FILTERED_ASSEMBLYS", delegate(AssemblyFilters filters) {
            return Assemblys.GetFilteredAssemblys(filters)
                .Convert(a => a.GetAllDefinedTypes())
                .Append(GetAllInspectedTypes())
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