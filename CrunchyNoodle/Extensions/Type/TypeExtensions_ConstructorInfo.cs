using System;
using System.Reflection;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_ConstructorInfo
    {
        static private OperationCache<List<ConstructorInfoEX>, Type, ConstructorInfoFilters> GET_FILTERED_CONSTRUCTORS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_CONSTRUCTORS", delegate(Type item, ConstructorInfoFilters filters) {
            return item.GetInstanceConstructors()
                .FilterBy(filters)
                .Convert(c => c.GetConstructorInfoEX())
                .ToList();
        });
        static public IEnumerable<ConstructorInfoEX> GetFilteredConstructors(this Type item, IEnumerable<Filterer<ConstructorInfo>> filters)
        {
            return GET_FILTERED_CONSTRUCTORS.Fetch(item, new ConstructorInfoFilters(filters));
        }
        static public IEnumerable<ConstructorInfoEX> GetFilteredConstructors(this Type item, params Filterer<ConstructorInfo>[] filters)
        {
            return item.GetFilteredConstructors((IEnumerable<Filterer<ConstructorInfo>>)filters);
        }
    }
}