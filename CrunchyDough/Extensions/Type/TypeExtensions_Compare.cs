using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Compare
    {
        static public bool IsAbstractClass(this Type item)
        {
            if (item.IsAbstract)
                return true;

            return false;
        }

        static public bool IsConcreteClass(this Type item)
        {
            if (item.IsAbstractClass() == false)
                return true;

            return false;
        }

        static public bool IsSealedClass(this Type item)
        {
            if (item.IsSealed)
                return true;

            return false;
        }

        static public bool IsStaticClass(this Type item)
        {
            if (item.IsSealedClass() && item.IsAbstractClass())
                return true;

            return false;
        }

        static public bool IsExtensionClass(this Type item)
        {
            if (item.IsStaticClass() && item.IsNonGenericClass())
            {
                if (item.HasCustomAttributeOfType<ExtensionAttribute>(false))
                    return true;
            }

            return false;
        }

        static public bool IsGenericClass(this Type item)
        {
            if (item.IsGenericType)
                return true;

            return false;
        }

        static public bool IsNonGenericClass(this Type item)
        {
            if (item.IsGenericClass() == false)
                return true;

            return false;
        }

        static public bool IsGenericTypelessClass(this Type item)
        {
            if (item.IsGenericClass())
            {
                if (item.ContainsGenericParameters)
                    return true;
            }

            return false;
        }

        static public bool IsGenericTypelessArray(this Type item)
        {
            if (item.IsArray() && item.ContainsGenericParameters)
                return true;

            return false;
        }

        static public bool IsGenericTypedClass(this Type item)
        {
            if (item.IsGenericClass())
            {
                if (item.ContainsGenericParameters == false)
                    return true;
            }

            return false;
        }

        static public bool IsGenericTypedClassOf(this Type item, Type parent)
        {
            if (item.IsGenericTypedClass())
            {
                if (item.GetGenericTypeDefinition() == parent)
                    return true;
            }

            return false;
        }
    }
}