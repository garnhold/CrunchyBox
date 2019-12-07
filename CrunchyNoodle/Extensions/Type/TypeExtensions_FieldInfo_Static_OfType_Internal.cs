using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_FieldInfo_Static_OfType_Internal<T>
    {
        static private OperationCache<List<FieldInfoEX>, Type> GET_ALL_STATIC_FIELDS_OF_TYPE = ReflectionCache.Get().NewOperationCache("GET_ALL_STATIC_FIELDS_OF_TYPE", delegate(Type item) {
            return item.GetFilteredStaticFields(
                Filterer_FieldInfo.CanBeTreatedAs<T>()
            ).ToList();
        });
        static public IEnumerable<FieldInfoEX> GetAllStaticFieldsOfType(Type item)
        {
            return GET_ALL_STATIC_FIELDS_OF_TYPE.Fetch(item);
        }

        static private OperationCache<List<FieldInfoEX>, Type, FieldInfoFilters> GET_FILTERED_STATIC_FIELDS_OF_TYPE = ReflectionCache.Get().NewOperationCache("GET_FILTERED_STATIC_FIELDS_OF_TYPE", delegate(Type item, FieldInfoFilters filters) {
            return item.GetAllStaticFieldsOfType<T>()
                .FilterBy(filters)
                .Convert(f => f.GetFieldInfoEX())
                .ToList();
        });
        static public IEnumerable<FieldInfoEX> GetFilteredStaticFieldsOfType(Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return GET_FILTERED_STATIC_FIELDS_OF_TYPE.Fetch(item, new FieldInfoFilters(filters));
        }

        static private OperationCache<List<ValueSetter<T>>, Type, FieldInfoFilters> GET_FILTERED_STATIC_FIELDS_OF_TYPE_VALUE_SETTERS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_STATIC_FIELDS_OF_TYPE_VALUE_SETTERS", delegate(Type item, FieldInfoFilters filters) {
            return item.GetFilteredStaticFieldsOfType<T>(filters)
                .Convert(f => f.GetValueSetter<T>())
                .ToList();
        });
        static public IEnumerable<ValueSetter<T>> GetFilteredStaticFieldsOfTypeValueSetters(Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return GET_FILTERED_STATIC_FIELDS_OF_TYPE_VALUE_SETTERS.Fetch(item, new FieldInfoFilters(filters));
        }

        static private OperationCache<List<ValueGetter<T>>, Type, FieldInfoFilters> GET_FILTERED_STATIC_FIELDS_OF_TYPE_VALUE_GETTERS = ReflectionCache.Get().NewOperationCache("GET_FILTERED_STATIC_FIELDS_OF_TYPE_VALUE_GETTERS", delegate(Type item, FieldInfoFilters filters) {
            return item.GetFilteredStaticFieldsOfType<T>(filters)
                .Convert(f => f.GetValueGetter<T>())
                .ToList();
        });
        static public IEnumerable<ValueGetter<T>> GetFilteredStaticFieldsOfTypeValueGetters(Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return GET_FILTERED_STATIC_FIELDS_OF_TYPE_VALUE_GETTERS.Fetch(item, new FieldInfoFilters(filters));
        }

        static private OperationCache<IteratorGetter<T>, Type, FieldInfoFilters> GET_FILTERED_STATIC_FIELDS_OF_TYPE_ITERATOR_GETTER = ReflectionCache.Get().NewOperationCache("GET_FILTERED_STATIC_FIELDS_OF_TYPE_ITERATOR_GETTER", delegate(Type item, FieldInfoFilters filters) {
            return item.CreateIteratorGetter<T>(item.GetFilteredStaticFieldsOfType<T>(filters));
        });
        static public IteratorGetter<T> GetFilteredStaticFieldsOfTypeIteratorGetter(Type item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return GET_FILTERED_STATIC_FIELDS_OF_TYPE_ITERATOR_GETTER.Fetch(item, new FieldInfoFilters(filters));
        }
    }
}