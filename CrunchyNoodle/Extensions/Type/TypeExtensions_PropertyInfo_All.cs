using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_PropertyInfo_All
    {
        static private OperationCache<List<PropertyInfoEX>, Type> GET_ALL_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_ALL_PROPERTYS", delegate(Type item) {
            return item.GetAllInstancePropertys()
                .Append(item.GetAllStaticPropertys())
                .ToList();
        });
        static public IEnumerable<PropertyInfoEX> GetAllPropertys(this Type item)
        {
            return GET_ALL_PROPERTYS.Fetch(item);
        }

        static private OperationCache<List<PropertyInfoEX>, Type, PropertyInfoFilters> GET_FILTERED_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_PROPERTYS", delegate(Type item, PropertyInfoFilters filters) {
            return item.GetFilteredInstancePropertys(filters)
                .Append(item.GetFilteredStaticPropertys(filters))
                .ToList();
        });
        static public IEnumerable<PropertyInfoEX> GetFilteredPropertys(this Type item, IEnumerable<Filterer<PropertyInfo>> filters)
        {
            return GET_FILTERED_PROPERTYS.Fetch(item, new PropertyInfoFilters(filters));
        }
        static public IEnumerable<PropertyInfoEX> GetFilteredPropertys(this Type item, params Filterer<PropertyInfo>[] filters)
        {
            return item.GetFilteredPropertys((IEnumerable<Filterer<PropertyInfo>>)filters);
        }
    }
}