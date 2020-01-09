using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public partial class Fields
    {
        static private OperationCache<List<FieldInfoEX>, FieldInfoFilters> GET_FILTERED_STATIC_FIELDS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_STATIC_FIELDS", delegate(FieldInfoFilters filters) {
            return Types.GetAllTypesFromFilteredAssemblys(filters.GetAssemblyFilters())
                .Convert(t => t.GetFilteredStaticFields(filters))
                .ToList();
        });
        static public IEnumerable<FieldInfoEX> GetFilteredStaticFields(IEnumerable<Filterer<FieldInfo>> filters)
        {
            return GET_FILTERED_STATIC_FIELDS.Fetch(new FieldInfoFilters(filters));
        }
        static public IEnumerable<FieldInfoEX> GetFilteredStaticFields(params Filterer<FieldInfo>[] filters)
        {
            return GetFilteredStaticFields((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}