using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_PropertyInfo_Static
    {
        static public IEnumerable<PropertyInfoEX> GetAllStaticPropertys(this Type item)
        {
            return item.GetStaticPropertys();
        }

        static private CompileTimeCache<List<PropertyInfoEX>, IdentifiableType, PropertyInfoFilters> GET_FILTERED_STATIC_PROPERTYS = ReflectionCache.Get().NewCompileTimeCache("GET_FILTERED_STATIC_PROPERTYS", PropertyInfoEXListHusker.INSTANCE, delegate(IdentifiableType item, PropertyInfoFilters filters) {
            return item.GetValue().GetStaticPropertys()
                .FilterBy(filters)
                .Convert(f => f.GetPropertyInfoEX())
                .ToList();
        });
        static public IEnumerable<PropertyInfoEX> GetFilteredStaticPropertys(this Type item, IEnumerable<Filterer<PropertyInfo>> filters)
        {
            return GET_FILTERED_STATIC_PROPERTYS.Fetch(item, new PropertyInfoFilters(filters));
        }
        static public IEnumerable<PropertyInfoEX> GetFilteredStaticPropertys(this Type item, params Filterer<PropertyInfo>[] filters)
        {
            return item.GetFilteredStaticPropertys((IEnumerable<Filterer<PropertyInfo>>)filters);
        }
    }
}