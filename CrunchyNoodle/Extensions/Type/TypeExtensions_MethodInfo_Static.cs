using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_MethodInfo_Static
    {
        static private CompileTimeCache<List<MethodInfoEX>, IdentifiableType, MethodInfoFilters> GET_FILTERED_STATIC_METHODS = ReflectionCache.Get().NewCompileTimeCache("GET_FILTERED_STATIC_METHODS", MethodInfoEXListHusker.INSTANCE, delegate(IdentifiableType item, MethodInfoFilters filters) {
            return item.GetValue().GetStaticMethods()
                .FilterBy(filters)
                .Convert(m => m.GetMethodInfoEX())
                .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetFilteredStaticMethods(this Type item, IEnumerable<Filterer<MethodInfo>> filters)
        {
            return GET_FILTERED_STATIC_METHODS.Fetch(item, new MethodInfoFilters(filters));
        }
        static public IEnumerable<MethodInfoEX> GetFilteredStaticMethods(this Type item, params Filterer<MethodInfo>[] filters)
        {
            return item.GetFilteredStaticMethods((IEnumerable<Filterer<MethodInfo>>)filters);
        }
    }
}