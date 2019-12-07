using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_PropertyInfo_Instance
    {
        static public IEnumerable<PropertyInfoEX> GetAllInstancePropertys(this Type item)
        {
            return item.GetInstancePropertys();
        }

        static private CompileTimeCache<List<PropertyInfoEX>, IdentifiableType, PropertyInfoFilters> GET_FILTERED_INSTANCE_PROPERTYS = ReflectionCache.Get().NewCompileTimeCache("GET_FILTERED_INSTANCE_PROPERTYS", PropertyInfoEXListHusker.INSTANCE, delegate(IdentifiableType item, PropertyInfoFilters filters) {
            return item.GetValue().GetAllInstancePropertys()
                .FilterBy(filters)
                .Convert(f => f.GetPropertyInfoEX())
                .ToList();
        });
        static public IEnumerable<PropertyInfoEX> GetFilteredInstancePropertys(this Type item, IEnumerable<Filterer<PropertyInfo>> filters)
        {
            return GET_FILTERED_INSTANCE_PROPERTYS.Fetch(item, new PropertyInfoFilters(filters));
        }
        static public IEnumerable<PropertyInfoEX> GetFilteredInstancePropertys(this Type item, params Filterer<PropertyInfo>[] filters)
        {
            return item.GetFilteredInstancePropertys((IEnumerable<Filterer<PropertyInfo>>)filters);
        }
    }
}