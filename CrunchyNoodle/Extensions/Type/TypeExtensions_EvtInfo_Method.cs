using System;
using System.Reflection;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_EvtInfo_Method
    {
        static private OperationCache<EvtInfoEX, Type, string, string> GET_INSTANCE_METHOD_EVT_INTERNAL = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_METHOD_EVT_INTERNAL", delegate(Type item, string add_method, string remove_method) {
            MethodInfoEX add = item.GetFilteredInstanceMethods(
                Filterer_MethodInfo.HasNoReturn(),
                Filterer_MethodInfo.IsNamed(add_method.TrimSuffix("()")),
                Filterer_MethodInfo.HasOneEffectiveParameter()
            ).GetFirst();

            MethodInfoEX remove = item.GetFilteredInstanceMethods(
                Filterer_MethodInfo.HasNoReturn(),
                Filterer_MethodInfo.IsNamed(remove_method.TrimSuffix("()")),
                Filterer_MethodInfo.HasOneEffectiveParameter()
            ).GetFirst();

            if (add != null && remove != null)
                return (EvtInfoEX)new EvtInfoEX_MethodPair(add, remove);

            return null;
        });
        static public EvtInfoEX GetInstanceMethodEvtInternal(this Type item, string add_method, string remove_method)
        {
            return GET_INSTANCE_METHOD_EVT_INTERNAL.Fetch(item, add_method, remove_method);
        }
    }
}