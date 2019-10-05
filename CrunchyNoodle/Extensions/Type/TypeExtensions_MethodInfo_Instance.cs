using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_MethodInfo_Instance
    {
        static private CompileTimeCache<List<MethodInfoEX>, IdentifiableType> GET_ALL_INSTANCE_METHODS = ReflectionCache.Get().NewCompileTimeCache("GET_ALL_INSTANCE_METHODS", MethodInfoEXListHusker.INSTANCE, delegate(IdentifiableType item) {
            return item.GetValue().GetTechnicalInstanceMethods()
                .Append(ExtensionMethods.GetAllExtensionMethodsForType(item))
                .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetAllInstanceMethods(this Type item)
        {
            return GET_ALL_INSTANCE_METHODS.Fetch(item);
        }
        
        static private CompileTimeCache<List<MethodInfoEX>, IdentifiableType, MethodInfoFilters> GET_FILTERED_INSTANCE_METHODS = ReflectionCache.Get().NewCompileTimeCache("GET_FILTERED_INSTANCE_METHODS", MethodInfoEXListHusker.INSTANCE, delegate(IdentifiableType item, MethodInfoFilters filters) {
            return item.GetValue().GetAllInstanceMethods()
                .FilterBy(filters)
                .Convert(m => m.GetMethodInfoEX())
                .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetFilteredInstanceMethods(this Type item, IEnumerable<Filterer<MethodInfo>> filters)
        {
            return GET_FILTERED_INSTANCE_METHODS.Fetch(item, new MethodInfoFilters(filters));
        }
        static public IEnumerable<MethodInfoEX> GetFilteredInstanceMethods(this Type item, params Filterer<MethodInfo>[] filters)
        {
            return item.GetFilteredInstanceMethods((IEnumerable<Filterer<MethodInfo>>)filters);
        }
    }
}