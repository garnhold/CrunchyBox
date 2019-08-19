using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class TypeExtensions_Interface
    {
        static private OperationCache<HashSet<Type>, Type, bool> GET_IMMEDIATE_INTERFACES = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_INTERFACES", delegate(Type item, bool flatten_interfaces) {
            HashSet<Type> flattened_interfaces = new HashSet<Type>(item.GetInterfaces());

            if (item.BaseType != null)
                flattened_interfaces.ExceptWith(item.BaseType.GetInterfaces());

            if (flatten_interfaces == false)
            {
                HashSet<Type> interfaces = new HashSet<Type>(flattened_interfaces);
                foreach (Type @interface in flattened_interfaces)
                    interfaces.ExceptWith(@interface.GetInterfaces());

                return interfaces;
            }

            return flattened_interfaces;
        });
        static public IEnumerable<Type> GetImmediateInterfaces(this Type item, bool flatten_interfaces = false)
        {
            return GET_IMMEDIATE_INTERFACES.Fetch(item, flatten_interfaces);
        }
    }
}