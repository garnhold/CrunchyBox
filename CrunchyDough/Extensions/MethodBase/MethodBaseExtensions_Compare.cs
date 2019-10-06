using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class MethodBaseExtensions_Compare
    {
        static public bool IsEffectivelyStaticMethod(this MethodBase item)
        {
            if (item.IsStatic && item.IsExtensionMethod() == false)
                return true;

            return false;
        }

        static public bool IsEffectivelyInstanceMethod(this MethodBase item)
        {
            if (item.IsEffectivelyStaticMethod() == false)
                return true;

            return false;
        }

        static public bool IsTechnicallyStaticMethod(this MethodBase item)
        {
            if (item.IsStatic)
                return true;

            return false;
        }

        static public bool IsTechnicallyInstanceMethod(this MethodBase item)
        {
            if (item.IsTechnicallyStaticMethod() == false)
                return true;

            return false;
        }

        static public bool IsExtensionMethod(this MethodBase item)
        {
            if (item.IsTechnicallyStaticMethod() && item.HasTechnicalParameters())
            {
                if (item.HasCustomAttributeOfType<ExtensionAttribute>(false))
                    return true;
            }

            return false;
        }

        static public bool IsExtensionMethod(this MethodBase item, Type type)
        {
            if (item.IsExtensionMethod() && item.CanTechnicalParameterHold(0, type))
                return true;

            return false;
        }

        static public bool IsExtensionMethod<T>(this MethodBase item)
        {
            return item.IsExtensionMethod(typeof(T));
        }

        static public bool IsNonExtensionMethod(this MethodBase item)
        {
            if (item.IsExtensionMethod() == false)
                return true;

            return false;
        }

        static public bool IsPropertySetMethod(this MethodBase item)
        {
            if (item.Name.StartsWith("set_"))
                return true;

            return false;
        }
        static public bool IsPropertyGetMethod(this MethodBase item)
        {
            if (item.Name.StartsWith("get_"))
                return true;

            return false;
        }
        static public bool IsPropertyMethod(this MethodBase item)
        {
            if (item.IsPropertySetMethod() || item.IsPropertyGetMethod())
                return true;

            return false;
        }

        static public bool IsGenericMethod(this MethodBase item)
        {
            if (item.IsGenericMethod)
                return true;

            return false;
        }

        static public bool IsNonGenericMethod(this MethodBase item)
        {
            if (item.IsGenericMethod == false)
                return true;

            return false;
        }

        static public bool IsGenericTypelessMethod(this MethodBase item)
        {
            if (item.IsGenericMethod())
            {
                if (item.ContainsGenericParameters)
                    return true;
            }

            return false;
        }

        static public bool IsGenericTypedMethod(this MethodBase item)
        {
            if (item.IsGenericMethod())
            {
                if (item.ContainsGenericParameters == false)
                    return true;
            }

            return false;
        }
    }
}