using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class ObjectExtensions_Values_Instance_Retrieve
    {
        static public IEnumerable<T> RetrieveMarkedInstanceValues<T, ATTRIBUTE_TYPE>(this Object item) where ATTRIBUTE_TYPE : Attribute
        {
            return item.GetMarkedInstanceValuesOfTypeOrIEnumerableIteratorGetter<T, ATTRIBUTE_TYPE>()(item);
        }

        static public bool TryRetrieveMarkedInstanceValue<T, ATTRIBUTE_TYPE>(this Object item, out T value) where ATTRIBUTE_TYPE : Attribute
        {
            ValueGetter<T> getter;

            if (item.GetMarkedInstanceValuesOfTypeValueGetters<T, ATTRIBUTE_TYPE>().TryGetFirst(out getter))
            {
                value = getter(item);
                return true;
            }

            value = default(T);
            return false;
        }
        static public T RetrieveMarkedInstanceValue<T, ATTRIBUTE_TYPE>(this Object item) where ATTRIBUTE_TYPE : Attribute
        {
            T value;

            item.TryRetrieveMarkedInstanceValue<T, ATTRIBUTE_TYPE>(out value);
            return value;
        }
    }
}