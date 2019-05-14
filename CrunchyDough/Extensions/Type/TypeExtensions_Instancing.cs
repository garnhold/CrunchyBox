using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class TypeExtensions_Instancing
    {
        static public object CreateInstance(this Type item, params object[] arguments)
        {
            if (item != null)
            {
                try
                {
                    return Activator.CreateInstance(item, arguments);
                }
                catch (TargetInvocationException ex)
                {
                    throw ex.InnerException;
                }
            }

            return null;
        }
        static public T CreateInstance<T>(this Type item, params object[] arguments)
        {
            return item.CreateInstance(arguments).Convert<T>();
        }

        static public IEnumerable<T> CreateInstances<T>(this IEnumerable<Type> item, params object[] arguments)
        {
            return item.Convert<Type, T>(t => t.CreateInstance<T>(arguments));
        }
    }
}