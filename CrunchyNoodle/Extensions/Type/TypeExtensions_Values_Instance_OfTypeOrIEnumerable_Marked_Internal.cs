using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Values_Instance_OfTypeOrIEnumerable_Marked_Internal<T, ATTRIBUTE_TYPE> where ATTRIBUTE_TYPE : Attribute
    {
        static private OperationCache<List<FieldInfoEX>, Type> GET_MARKED_INSTANCE_FIELDS_OF_TYPE_OR_IENUMERABLE = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_FIELDS_OF_TYPE_OR_IENUMERABLE", delegate(Type item) {
            return item.GetFilteredInstanceFields(
                Filterer_FieldInfo.CanBeTreatedAs<T>() | Filterer_FieldInfo.CanBeTreatedAs<IEnumerable<T>>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<ATTRIBUTE_TYPE>()
            ).ToList();
        });
        static private IEnumerable<FieldInfoEX> GetMarkedInstanceFieldsOfTypeOrIEnumerable(Type item)
        {
            return GET_MARKED_INSTANCE_FIELDS_OF_TYPE_OR_IENUMERABLE.Fetch(item);
        }

        static private OperationCache<List<MethodInfoEX>, Type> GET_MARKED_INSTANCE_METHODS_WITH_RETURN_OR_IENUMERABLE_AND_NO_EFFECTIVE_PARAMETERS = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_METHODS_WITH_RETURN_OR_IENUMERABLE_AND_NO_EFFECTIVE_PARAMETERS", delegate(Type item) {
            return item.GetFilteredInstanceMethods(
                Filterer_MethodInfo.CanReturnInto<T>() | Filterer_MethodInfo.CanReturnInto<IEnumerable<T>>(),
                Filterer_MethodInfo.HasNoEffectiveParameters(),
                Filterer_MethodInfo.HasCustomAttributeOfType<ATTRIBUTE_TYPE>()
            ).ToList();
        });
        static private IEnumerable<MethodInfoEX> GetMarkedInstanceMethodsWithReturnOrIEnumerableAndNoEffectiveParameters(Type item)
        {
            return GET_MARKED_INSTANCE_METHODS_WITH_RETURN_OR_IENUMERABLE_AND_NO_EFFECTIVE_PARAMETERS.Fetch(item);
        }

        static private OperationCache<IteratorGetter<T>, Type> GET_MARKED_INSTANCE_VALUES_OF_TYPE_OR_IENUMERABLE_ITERATOR_GETTER = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_VALUES_OF_TYPE_OR_IENUMERABLE_ITERATOR_GETTER", delegate(Type item) {
            return item.CreateIteratorGetter<T>(
                GetMarkedInstanceFieldsOfTypeOrIEnumerable(item),
                GetMarkedInstanceMethodsWithReturnOrIEnumerableAndNoEffectiveParameters(item)
            );
        });
        static public IteratorGetter<T> GetMarkedInstanceValuesOfTypeOrIEnumerableIteratorGetter(Type item)
        {
            return GET_MARKED_INSTANCE_VALUES_OF_TYPE_OR_IENUMERABLE_ITERATOR_GETTER.Fetch(item);
        }
    }
}