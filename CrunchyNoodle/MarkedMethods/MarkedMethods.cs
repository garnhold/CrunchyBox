using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public partial class MarkedMethods<T> where T : Attribute
    {
        static private CompileTimeCache<List<MethodInfoEX>> GET_ALL_MARKED_STATIC_METHODS = ReflectionCache.Get().NewCompileTimeCache("GET_ALL_MARKED_STATIC_METHODS_" + typeof(T).Name, MethodInfoEXListHusker.INSTANCE, delegate() {
            return Types.GetFilteredTypes(
                Filterer_Type.IsStaticClass(),
                Filterer_Type.HasCustomAttributeOfType<T>(false)
            )
            .Convert(t => t.GetFilteredStaticMethods(Filterer_MethodInfo.HasCustomAttributeOfType<T>()))
            .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetAllMarkedStaticMethods()
        {
            return GET_ALL_MARKED_STATIC_METHODS.Fetch();
        }

        static private OperationCache<List<MethodInfoEX>, MethodInfoFilters> GET_FILTERED_MARKED_STATIC_METHODS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_MARKED_STATIC_METHODS", delegate(MethodInfoFilters filters) {
            return GetAllMarkedStaticMethods()
                .FilterBy(filters)
                .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetFilteredMarkedStaticMethods(IEnumerable<Filterer<MethodInfo>> filters)
        {
            return GET_FILTERED_MARKED_STATIC_METHODS.Fetch(new MethodInfoFilters(filters));
        }
        static public IEnumerable<MethodInfoEX> GetFilteredMarkedStaticMethods(params Filterer<MethodInfo>[] filters)
        {
            return GetFilteredMarkedStaticMethods((IEnumerable<Filterer<MethodInfo>>)filters);
        }
    }
}