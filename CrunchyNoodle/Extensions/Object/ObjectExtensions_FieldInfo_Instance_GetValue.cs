using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_FieldInfo_Instance_GetValue
    {
        static public IEnumerable<T> GetFilteredInstanceFieldValues<T>(this Object item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return item.GetFilteredInstanceFieldsOfTypeIteratorGetter<T>(filters)(item);
        }
        static public IEnumerable<T> GetFilteredInstanceFieldValues<T>(this Object item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldValues<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public bool TryGetFilteredInstanceFieldValue<T>(this Object item, out T value, IEnumerable<Filterer<FieldInfo>> filters)
        {
            ValueGetter<T> getter;

            if (item.GetFilteredInstanceFieldsOfTypeValueGetters<T>(filters).TryGetFirst(out getter))
            {
                value = getter(item);
                return true;
            }

            value = default(T);
            return false;
        }
        static public bool TryGetFilteredInstanceFieldValue<T>(this Object item, out T value, params Filterer<FieldInfo>[] filters)
        {
            return item.TryGetFilteredInstanceFieldValue<T>(out value, (IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public T GetFilteredInstanceFieldValue<T>(this Object item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            T value;

            item.TryGetFilteredInstanceFieldValue<T>(out value, filters);
            return value;
        }
        static public T GetFilteredInstanceFieldValue<T>(this Object item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldValue<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}