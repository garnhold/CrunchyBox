using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class TypeExtensions_Instancing_Forced
    {
        static public object CreateForcedInstance(this Type item, params object[] arguments)
        {
            if (item != null)
            {
                try
                {
                    return Activator.CreateInstance(item,
                        BindingFlags.Instance |
                        BindingFlags.NonPublic |
                        BindingFlags.Public |
                        BindingFlags.DeclaredOnly,
                    null, arguments, null, null);
                }
                catch (TargetInvocationException ex)
                {
                    throw ex.InnerException;
                }
            }

            return null;
        }
        static public T CreateForcedInstance<T>(this Type item, params object[] arguments)
        {
            return item.CreateForcedInstance(arguments).Convert<T>();
        }

        static public IEnumerable<T> CreateForcedInstances<T>(this IEnumerable<Type> item, params object[] arguments)
        {
            return item.Convert<Type, T>(t => t.CreateForcedInstance<T>(arguments));
        }
    }
}