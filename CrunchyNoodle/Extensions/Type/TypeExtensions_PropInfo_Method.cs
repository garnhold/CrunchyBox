using System;
using System.Reflection;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_PropInfo_Method
    {
        static private OperationCache<IDictionary<string, PropInfoEX_MethodPair>, Type> GET_INSTANCE_METHOD_PROP_DICTIONARY = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_METHOD_PROP_DICTIONARY", delegate (Type type) {
            Pedia<string, PropInfoEX_MethodPair> methods = new Pedia<string, PropInfoEX_MethodPair>(() => new PropInfoEX_MethodPair());

            foreach (MethodInfoEX method in type.GetFilteredInstanceMethods(Filterer_MethodInfo.IsPropCompatible()))
            {
                string name = method.Name.DetectEntityPropName();

                if (method.IsPropSetCompatible())
                    methods.GetValue(name).SetSetMethod(method);
                else if (method.IsPropGetCompatible())
                    methods.GetValue(name).SetGetMethod(method);
            }

            return (IDictionary<string, PropInfoEX_MethodPair>)methods.ToDictionary();
        });

        static public PropInfoEX GetInstanceMethodProp(this Type item, string name)
        {
            return GET_INSTANCE_METHOD_PROP_DICTIONARY.Fetch(item)
                .GetValue(name);
        }

        static public IEnumerable<PropInfoEX> GetAllInstanceMethodProps(this Type item)
        {
            return GET_INSTANCE_METHOD_PROP_DICTIONARY.Fetch(item).Values;
        }
    }
}