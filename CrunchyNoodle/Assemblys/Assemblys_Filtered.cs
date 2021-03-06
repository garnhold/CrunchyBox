using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public partial class Assemblys
    {
        static private OperationCache<List<Assembly>, AssemblyFilters> GET_FILTERED_ASSEMBLYS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_ASSEMBLYS", delegate(AssemblyFilters filters) {
            return GetAllInspectedAssemblys()
                .FilterBy(filters)
                .ToList();
        });
        static public IEnumerable<Assembly> GetFilteredAssemblys(IEnumerable<Filterer<Assembly>> filters)
        {
            return GET_FILTERED_ASSEMBLYS.Fetch(new AssemblyFilters(filters));
        }
        static public IEnumerable<Assembly> GetFilteredAssemblys(params Filterer<Assembly>[] filters)
        {
            return GetFilteredAssemblys((IEnumerable<Filterer<Assembly>>)filters);
        }
    }
}