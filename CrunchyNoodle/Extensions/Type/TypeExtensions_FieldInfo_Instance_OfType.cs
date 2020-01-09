using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_FieldInfo_Instance_OfType
    {
        static public IEnumerable<FieldInfoEX> GetAllInstanceFieldsOfType<T>(this Type item)
        {
            return TypeExtensions_FieldInfo_Instance_OfType_Internal<T>.GetAllInstanceFieldsOfType(item);
        }

        static public IEnumerable<FieldInfoEX> GetFilteredInstanceFieldsOfType<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return TypeExtensions_FieldInfo_Instance_OfType_Internal<T>.GetFilteredInstanceFieldsOfType(item, filters);
        }
        static public IEnumerable<FieldInfoEX> GetFilteredInstanceFieldsOfType<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldsOfType<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IEnumerable<ValueSetter<T>> GetFilteredInstanceFieldsOfTypeValueSetters<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return TypeExtensions_FieldInfo_Instance_OfType_Internal<T>.GetFilteredInstanceFieldsOfTypeValueSetters(item, filters);
        }
        static public IEnumerable<ValueSetter<T>> GetFilteredInstanceFieldsOfTypeValueSetters<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldsOfTypeValueSetters<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IEnumerable<ValueGetter<T>> GetFilteredInstanceFieldsOfTypeValueGetters<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return TypeExtensions_FieldInfo_Instance_OfType_Internal<T>.GetFilteredInstanceFieldsOfTypeValueGetters(item, filters);
        }
        static public IEnumerable<ValueGetter<T>> GetFilteredInstanceFieldsOfTypeValueGetters<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldsOfTypeValueGetters<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IteratorGetter<T> GetFilteredInstanceFieldsOfTypeIteratorGetter<T>(this Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return TypeExtensions_FieldInfo_Instance_OfType_Internal<T>.GetFilteredInstanceFieldsOfTypeIteratorGetter(item, filters);
        }
        static public IteratorGetter<T> GetFilteredInstanceFieldsOfTypeIteratorGetter<T>(this Type item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldsOfTypeIteratorGetter<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}