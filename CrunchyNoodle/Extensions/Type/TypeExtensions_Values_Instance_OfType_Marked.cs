using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_Values_Instance_OfType_Marked
    {
        static public IEnumerable<ValueSetter<T>> GetMarkedInstanceValuesOfTypeValueSetters<T, ATTRIBUTE_TYPE>(this Type item) where ATTRIBUTE_TYPE : Attribute
        {
            return TypeExtensions_Values_Instance_OfType_Marked_Internal<T, ATTRIBUTE_TYPE>.GetMarkedInstanceValuesOfTypeValueSetters(item);
        }

        static public IEnumerable<ValueGetter<T>> GetMarkedInstanceValuesOfTypeValueGetters<T, ATTRIBUTE_TYPE>(this Type item) where ATTRIBUTE_TYPE : Attribute
        {
            return TypeExtensions_Values_Instance_OfType_Marked_Internal<T, ATTRIBUTE_TYPE>.GetMarkedInstanceValuesOfTypeValueGetters(item);
        }
    }
}