using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_FieldInfo_Static
    {
        static public IEnumerable<FieldInfoEX> GetAllStaticFields(this Type item)
        {
            return item.GetStaticFields();
        }

        static private CompileTimeCache<List<FieldInfoEX>, IdentifiableType, FieldInfoFilters> GET_FILTERED_STATIC_FIELDS = ReflectionCache.Get().NewCompileTimeCache("GET_FILTERED_STATIC_FIELDS", FieldInfoEXListHusker.INSTANCE, delegate(IdentifiableType item, FieldInfoFilters filters) {
            return item.GetValue().GetStaticFields()
                .FilterBy(filters)
                .Convert(f => f.GetFieldInfoEX())
                .ToList();
        });
        static public IEnumerable<FieldInfoEX> GetFilteredStaticFields(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return GET_FILTERED_STATIC_FIELDS.Fetch(item, new FieldInfoFilters(filters));
        }
        static public IEnumerable<FieldInfoEX> GetFilteredStaticFields(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredStaticFields((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}