using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_FieldInfo_Instance
    {
        static public IEnumerable<FieldInfoEX> GetAllInstanceFields(this Type item)
        {
            return item.GetInstanceFields();
        }

        static private CompileTimeCache<List<FieldInfoEX>, IdentifiableType, FieldInfoFilters> GET_FILTERED_INSTANCE_FIELDS = ReflectionCache.Get().NewCompileTimeCache("GET_FILTERED_INSTANCE_FIELDS", FieldInfoEXListHusker.INSTANCE, delegate(IdentifiableType item, FieldInfoFilters filters) {
            return item.GetValue().GetAllInstanceFields()
                .FilterBy(filters)
                .ToList();
        });
        static public IEnumerable<FieldInfoEX> GetFilteredInstanceFields(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return GET_FILTERED_INSTANCE_FIELDS.Fetch(item, new FieldInfoFilters(filters));
        }
        static public IEnumerable<FieldInfoEX> GetFilteredInstanceFields(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFields((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}