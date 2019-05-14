using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_FieldInfo_Instance_OfType
    {
        static public IEnumerable<FieldInfoEX> GetInstanceFieldsOfType<T>(this Object item)
        {
            return item.GetType().GetAllInstanceFieldsOfType<T>();
        }

        static public IEnumerable<FieldInfoEX> GetFilteredInstanceFieldsOfType<T>(this Object item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return item.GetType().GetFilteredInstanceFieldsOfType<T>(filters);
        }
        static public IEnumerable<FieldInfoEX> GetFilteredInstanceFieldsOfType<T>(this Object item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldsOfType<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IEnumerable<ValueSetter<T>> GetFilteredInstanceFieldsOfTypeValueSetters<T>(this Object item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return item.GetType().GetFilteredInstanceFieldsOfTypeValueSetters<T>(filters);
        }
        static public IEnumerable<ValueSetter<T>> GetFilteredInstanceFieldsOfTypeValueSetters<T>(this Object item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldsOfTypeValueSetters<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IEnumerable<ValueGetter<T>> GetFilteredInstanceFieldsOfTypeValueGetters<T>(this Object item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return item.GetType().GetFilteredInstanceFieldsOfTypeValueGetters<T>(filters);
        }
        static public IEnumerable<ValueGetter<T>> GetFilteredInstanceFieldsOfTypeValueGetters<T>(this Object item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldsOfTypeValueGetters<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }

        static public IteratorGetter<T> GetFilteredInstanceFieldsOfTypeIteratorGetter<T>(this Object item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return item.GetType().GetFilteredInstanceFieldsOfTypeIteratorGetter<T>(filters);
        }
        static public IteratorGetter<T> GetFilteredInstanceFieldsOfTypeIteratorGetter<T>(this Object item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFieldsOfTypeIteratorGetter<T>((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}