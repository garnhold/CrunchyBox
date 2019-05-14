using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_Values_Instance_OfType_Marked
    {
        static public IEnumerable<ValueSetter<T>> GetMarkedInstanceValuesOfTypeValueSetters<T, ATTRIBUTE_TYPE>(this Object item) where ATTRIBUTE_TYPE : Attribute
        {
            return item.GetType().GetMarkedInstanceValuesOfTypeValueSetters<T, ATTRIBUTE_TYPE>();
        }

        static public IEnumerable<ValueGetter<T>> GetMarkedInstanceValuesOfTypeValueGetters<T, ATTRIBUTE_TYPE>(this Object item) where ATTRIBUTE_TYPE : Attribute
        {
            return item.GetType().GetMarkedInstanceValuesOfTypeValueGetters<T, ATTRIBUTE_TYPE>();
        }
    }
}