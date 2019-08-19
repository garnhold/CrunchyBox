using System;
using System.Reflection;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_MethodInfo_All
    {
        static private OperationCache<List<MethodInfoEX>, Type> GET_ALL_METHODS = ReflectionCache.Get().NewOperationCache("GET_ALL_METHODS", delegate(Type item) {
            return item.GetAllInstanceMethods()
                .Append(item.GetStaticMethods())
                .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetAllMethods(this Type item)
        {
            return GET_ALL_METHODS.Fetch(item);
        }

        static private OperationCache<List<MethodInfoEX>, Type, MethodInfoFilters> GET_FILTERED_METHODS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_METHODS", delegate(Type item, MethodInfoFilters filters) {
            return item.GetFilteredInstanceMethods(filters)
                .Append(item.GetFilteredStaticMethods(filters))
                .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetFilteredMethods(this Type item, IEnumerable<Filterer<MethodInfo>> filters)
        {
            return GET_FILTERED_METHODS.Fetch(item, new MethodInfoFilters(filters));
        }
        static public IEnumerable<MethodInfoEX> GetFilteredMethods(this Type item, params Filterer<MethodInfo>[] filters)
        {
            return item.GetFilteredMethods((IEnumerable<Filterer<MethodInfo>>)filters);
        }
    }
}