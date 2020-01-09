using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_IEnumerableType
    {
        static private OperationCache<Type, Type> GET_IENUMERABLE_TYPE = ReflectionCache.Get().NewOperationCache("GET_IENUMERABLE_TYPE", delegate(Type item) {
            if (item.IsArray)
                return item.GetElementType();

            if (item.CanBeTreatedAs<IEnumerable>())
            {
                Type ienumerable_interface = item.GetAllInterfaces()
                    .Narrow(t => t.CanBeTreatedAs<IEnumerable>())
                    .Narrow(t => t.IsGenericTypedClass())
                    .Narrow(t => t.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                    .GetFirst();

                if (ienumerable_interface != null)
                    return ienumerable_interface.GetGenericArgument(0);

                return typeof(object);
            }

            return null;
        });
        static public Type GetIEnumerableType(this Type item)
        {
            return GET_IENUMERABLE_TYPE.Fetch(item);
        }
    }
}