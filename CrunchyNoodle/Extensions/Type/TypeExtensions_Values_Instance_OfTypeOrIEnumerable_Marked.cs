using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Values_Instance_OfTypeOrIEnumerable_Marked
    {
        static public IteratorGetter<T> GetMarkedInstanceValuesOfTypeOrIEnumerableIteratorGetter<T, ATTRIBUTE_TYPE>(this Type item) where ATTRIBUTE_TYPE : Attribute
        {
            return TypeExtensions_Values_Instance_OfTypeOrIEnumerable_Marked_Internal<T, ATTRIBUTE_TYPE>.GetMarkedInstanceValuesOfTypeOrIEnumerableIteratorGetter(item);
        }
    }
}