using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_FieldInfo_All
    {
        static private OperationCache<List<FieldInfoEX>, Type> GET_ALL_FIELDS = ReflectionCache.Get().NewOperationCache("GET_ALL_FIELDS", delegate(Type item) {
            return item.GetAllInstanceFields()
                .Append(item.GetAllStaticFields())
                .ToList();
        });
        static public IEnumerable<FieldInfoEX> GetAllFields(this Type item)
        {
            return GET_ALL_FIELDS.Fetch(item);
        }

        static private OperationCache<List<FieldInfoEX>, Type, FieldInfoFilters> GET_FILTERED_FIELDS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_FIELDS", delegate(Type item, FieldInfoFilters filters) {
            return item.GetFilteredInstanceFields(filters)
                .Append(item.GetFilteredStaticFields(filters))
                .ToList();
        });
        static public IEnumerable<FieldInfoEX> GetFilteredFields(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return GET_FILTERED_FIELDS.Fetch(item, new FieldInfoFilters(filters));
        }
        static public IEnumerable<FieldInfoEX> GetFilteredFields(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredFields((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}