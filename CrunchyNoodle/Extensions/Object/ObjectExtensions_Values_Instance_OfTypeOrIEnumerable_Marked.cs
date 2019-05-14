using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_Values_Instance_OfTypeOrIEnumerable_Marked
    {
        static public IteratorGetter<T> GetMarkedInstanceValuesOfTypeOrIEnumerableIteratorGetter<T, ATTRIBUTE_TYPE>(this Object item) where ATTRIBUTE_TYPE : Attribute
        {
            return item.GetType().GetMarkedInstanceValuesOfTypeOrIEnumerableIteratorGetter<T, ATTRIBUTE_TYPE>();
        }
    }
}