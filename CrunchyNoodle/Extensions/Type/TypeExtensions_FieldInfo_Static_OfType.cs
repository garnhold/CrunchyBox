using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_FieldInfo_Static_OfType
    {
        static public IEnumerable<FieldInfoEX> GetAllStaticFieldsOfType<T>(this Type item)
        {
            return TypeExtensions_FieldInfo_Static_OfType_Internal<T>.GetAllStaticFieldsOfType(item);
        }

        static public IEnumerable<FieldInfoEX> GetFilteredStaticFieldsOfType<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return TypeExtensions_FieldInfo_Static_OfType_Internal<T>.GetFilteredStaticFieldsOfType(item, filters);
        }
        static public IEnumerable<FieldInfoEX> GetFilteredStaticFieldsOfType<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredStaticFieldsOfType<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IEnumerable<ValueSetter<T>> GetFilteredStaticFieldsOfTypeValueSetters<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return TypeExtensions_FieldInfo_Static_OfType_Internal<T>.GetFilteredStaticFieldsOfTypeValueSetters(item, filters);
        }
        static public IEnumerable<ValueSetter<T>> GetFilteredStaticFieldsOfTypeValueSetters<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredStaticFieldsOfTypeValueSetters<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IEnumerable<ValueGetter<T>> GetFilteredStaticFieldsOfTypeValueGetters<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return TypeExtensions_FieldInfo_Static_OfType_Internal<T>.GetFilteredStaticFieldsOfTypeValueGetters(item, filters);
        }
        static public IEnumerable<ValueGetter<T>> GetFilteredStaticFieldsOfTypeValueGetters<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredStaticFieldsOfTypeValueGetters<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IteratorGetter<T> GetFilteredStaticFieldsOfTypeIteratorGetter<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return TypeExtensions_FieldInfo_Static_OfType_Internal<T>.GetFilteredStaticFieldsOfTypeIteratorGetter(item, filters);
        }
        static public IteratorGetter<T> GetFilteredStaticFieldsOfTypeIteratorGetter<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredStaticFieldsOfTypeIteratorGetter<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}