using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_FieldInfo_Static_GetValue
    {
        static public IEnumerable<T> GetFilteredStaticFieldValues<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return item.GetFilteredStaticFieldsOfTypeIteratorGetter<T>(filters)(null);
        }
        static public IEnumerable<T> GetFilteredStaticFieldValues<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredStaticFieldValues<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public bool TryGetFilteredStaticFieldValue<T>(this Type item, out T value, IEnumerable<Filterer<FieldInfo>> filters)
        {
            ValueGetter<T> getter;

            if (item.GetFilteredStaticFieldsOfTypeValueGetters<T>(filters).TryGetFirst(out getter))
            {
                value = getter(null);
                return true;
            }

            value = default(T);
            return false;
        }
        static public bool TryGetFilteredStaticFieldValue<T>(this Type item, out T value, params Filterer<FieldInfo>[] filters)
        {
            return item.TryGetFilteredStaticFieldValue<T>(out value, (IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public T GetFilteredStaticFieldValue<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            T value;

            item.TryGetFilteredStaticFieldValue<T>(out value, filters);
            return value;
        }
        static public T GetFilteredStaticFieldValue<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredStaticFieldValue<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}