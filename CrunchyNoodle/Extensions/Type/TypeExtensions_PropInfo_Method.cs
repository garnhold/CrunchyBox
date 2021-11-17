using System;
using System.Reflection;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_PropInfo_Method
    {
        static private OperationCache<Dictionary<string, MethodInfoEX>, Type> GET_INSTANCE_GET_METHOD_DICTIONARY = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_GET_METHOD_DICTIONARY", delegate (Type item) {
            return item.GetFilteredInstanceMethods(Filterer_MethodInfo.IsPropGetCompatible())
                .ToDictionarySkipValues(m => m.Name);
        });
        static private OperationCache<Dictionary<string, MethodInfoEX>, Type> GET_INSTANCE_SET_METHOD_DICTIONARY = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_SET_METHOD_DICTIONARY", delegate (Type item) {
            return item.GetFilteredInstanceMethods(Filterer_MethodInfo.IsPropSetCompatible())
                .ToDictionarySkipValues(m => m.Name);
        });

        static private OperationCache<PropInfoEX, Type, string, string> GET_INSTANCE_METHOD_PROP_INTERNAL = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_METHOD_PROP_INTERNAL", delegate (Type item, string set_method, string get_method) {
            MethodInfoEX set = GET_INSTANCE_SET_METHOD_DICTIONARY.Fetch(item).GetValue(set_method);
            MethodInfoEX get = GET_INSTANCE_GET_METHOD_DICTIONARY.Fetch(item).GetValue(get_method);

            if (set != null || get != null)
                return (PropInfoEX)new PropInfoEX_MethodPair(set, get);

            return null;
        });
        static public PropInfoEX GetInstanceMethodPropInternal(this Type item, string set_method, string get_method)
        {
            return GET_INSTANCE_METHOD_PROP_INTERNAL.Fetch(item, set_method, get_method);
        }

        static private OperationCache<PropInfoEX, Type, string> GET_INSTANCE_METHOD_PROP = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_METHOD_PROP", delegate (Type item, string name) {
            string set_method;
            string get_method;

            name = name.TrimSuffix("()");
            if (name.TryDetectEntityPropMethodPair(out set_method, out get_method))
                return item.GetInstanceMethodPropInternal(set_method, get_method);

            return null;
        });
        static public PropInfoEX GetInstanceMethodProp(this Type item, string name)
        {
            return GET_INSTANCE_METHOD_PROP.Fetch(item, name);
        }

        static private OperationCache<List<PropInfoEX>, Type> GET_ALL_INSTANCE_METHOD_PROPS = ReflectionCache.Get().NewOperationCache("GET_ALL_INSTANCE_METHOD_PROPS", delegate (Type type) {
            return type.GetFilteredInstanceMethods(
                Filterer_MethodInfo.IsPropCompatible()
            ).Convert(m => type.GetInstanceMethodProp(m.Name))
            .SkipNull()
            .Unique()
            .ToList();
        });
        static public IEnumerable<PropInfoEX> GetAllInstanceMethodProps(this Type item)
        {
            return GET_ALL_INSTANCE_METHOD_PROPS.Fetch(item);
        }
    }
}