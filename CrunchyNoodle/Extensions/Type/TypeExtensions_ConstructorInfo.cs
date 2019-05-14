using System;
using System.Reflection;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_ConstructorInfo
    {
        static private OperationCache<List<ConstructorInfoEX>, Type, ConstructorInfoFilters> GET_FILTERED_CONSTRUCTORS = ReflectionCache.Get().NewOperationCache(delegate(Type item, ConstructorInfoFilters filters) {
            return item.GetInstanceConstructors()
                .FilterBy(filters)
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