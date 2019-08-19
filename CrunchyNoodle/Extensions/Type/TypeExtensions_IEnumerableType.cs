using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_IEnumerableType
    {
        static private OperationCache<Type, Type> GET_IENUMERABLE_TYPE = ReflectionCache.Get().NewOperationCache("GET_IENUMERABLE_TYPE", delegate(Type item) {
            if (item.IsArray)
                return item.GetElementType();

            if (item.CanBeTreatedAs<IEnumerable>())
            {
                MethodInfo method = item.GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("GetEnumerator"),
                    Filterer_MethodInfo.IsPublicMethod()
                )
                .FindFirst(m => m.ReturnType.IsGenericTypedClass());

                if (method != null)
                    return method.ReturnType.GetGenericArgument(0);

                Type ienumerable_interface = item.GetAllInterfaces()
                    .Narrow(t => t.CanBeTreatedAs<IEnumerable>())
                    .Narrow(t => t.IsGenericTypedClass())
                    .Narrow(t => t == typeof(IEnumerable<>).MakeGenericType(t.GetGenericArgument(0)))
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