using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Values_Instance_OfType_Marked_Internal<T, ATTRIBUTE_TYPE> where ATTRIBUTE_TYPE : Attribute
    {
        static private OperationCache<List<FieldInfoEX>, Type> GET_MARKED_INSTANCE_FIELDS_OF_TYPE = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_FIELDS_OF_TYPE", delegate(Type item) {
            return item.GetFilteredInstanceFields(
                Filterer_FieldInfo.CanBeTreatedAs<T>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<ATTRIBUTE_TYPE>()
            )
            .ToList();
        });
        static private IEnumerable<FieldInfoEX> GetMarkedInstanceFieldsOfType(Type item)
        {
            return GET_MARKED_INSTANCE_FIELDS_OF_TYPE.Fetch(item);
        }
        static private OperationCache<List<ValueGetter<T>>, Type> GET_MARKED_INSTANCE_FIELDS_OF_TYPE_VALUE_GETTERS = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_FIELDS_OF_TYPE_VALUE_GETTERS", delegate(Type item) {
            return GetMarkedInstanceFieldsOfType(item)
                .Convert(f => f.GetValueGetter<T>())
                .ToList();
        });
        static private IEnumerable<ValueGetter<T>> GetMarkedInstanceFieldsOfTypeValueGetters(Type item)
        {
            return GET_MARKED_INSTANCE_FIELDS_OF_TYPE_VALUE_GETTERS.Fetch(item);
        }
        static private OperationCache<List<ValueSetter<T>>, Type> GET_MARKED_INSTANCE_FIELDS_OF_TYPE_VALUE_SETTERS = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_FIELDS_OF_TYPE_VALUE_SETTERS", delegate(Type item) {
            return GetMarkedInstanceFieldsOfType(item)
                .Convert(f => f.GetValueSetter<T>())
                .ToList();
        });
        static private IEnumerable<ValueSetter<T>> GetMarkedInstanceFieldsOfTypeValueSetters(Type item)
        {
            return GET_MARKED_INSTANCE_FIELDS_OF_TYPE_VALUE_SETTERS.Fetch(item);
        }

        static private OperationCache<List<MethodInfoEX>, Type> GET_MARKED_INSTANCE_METHODS_WITH_RETURN_AND_NO_EFFECTIVE_PARAMETERS = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_METHODS_WITH_RETURN_AND_NO_EFFECTIVE_PARAMETERS", delegate(Type item) {
            return item.GetFilteredInstanceMethods(
                Filterer_MethodInfo.CanReturnInto<T>(),
                Filterer_MethodInfo.HasNoEffectiveParameters(),
                Filterer_MethodInfo.HasCustomAttributeOfType<ATTRIBUTE_TYPE>()
            ).ToList();
        });
        static private IEnumerable<MethodInfoEX> GetMarkedInstanceMethodsWithReturnAndNoEffectiveParameters(Type item)
        {
            return GET_MARKED_INSTANCE_METHODS_WITH_RETURN_AND_NO_EFFECTIVE_PARAMETERS.Fetch(item);
        }
        static private OperationCache<List<ValueGetter<T>>, Type> GET_MARKED_INSTANCE_METHODS_WITH_RETURN_AND_NO_EFFECTIVE_PARAMETERS_VALUE_GETTERS = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_METHODS_WITH_RETURN_AND_NO_EFFECTIVE_PARAMETERS_VALUE_GETTERS", delegate(Type item) {
            return GetMarkedInstanceMethodsWithReturnAndNoEffectiveParameters(item)
                .Convert(m => m.GetSimulatedValueGetter<T>())
                .ToList();
        });
        static private IEnumerable<ValueGetter<T>> GetMarkedInstanceMethodsWithReturnAndNoEffectiveParametersValueGetters(Type item)
        {
            return GET_MARKED_INSTANCE_METHODS_WITH_RETURN_AND_NO_EFFECTIVE_PARAMETERS_VALUE_GETTERS.Fetch(item);
        }

        static private OperationCache<List<MethodInfoEX>, Type> GET_MARKED_INSTANCE_METHODS_WITHOUT_RETURN_AND_PARAMETER_OF_TYPE = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_METHODS_WITHOUT_RETURN_AND_PARAMETER_OF_TYPE", delegate(Type item) {
            return item.GetFilteredInstanceMethods(
                Filterer_MethodInfo.HasNoReturn(),
                Filterer_MethodInfo.CanEffectiveParametersHold<T>(),
                Filterer_MethodInfo.HasCustomAttributeOfType<ATTRIBUTE_TYPE>()
            ).ToList();
        });
        static private IEnumerable<MethodInfoEX> GetMarkedInstanceMethodsWithoutReturnAndParameterOfType(Type item)
        {
            return GET_MARKED_INSTANCE_METHODS_WITHOUT_RETURN_AND_PARAMETER_OF_TYPE.Fetch(item);
        }
        static private OperationCache<List<ValueSetter<T>>, Type> GET_MARKED_INSTANCE_METHODS_WITHOUT_RETURN_AND_PARAMETER_OF_TYPE_VALUE_SETTERS = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_METHODS_WITHOUT_RETURN_AND_PARAMETER_OF_TYPE_VALUE_SETTERS", delegate(Type item) {
            return GetMarkedInstanceMethodsWithoutReturnAndParameterOfType(item)
                .Convert(m => m.GetSimulatedValueSetter<T>())
                .ToList();
        });
        static private IEnumerable<ValueSetter<T>> GetMarkedInstanceMethodsWithoutReturnAndParameterOfTypeValueSetters(Type item)
        {
            return GET_MARKED_INSTANCE_METHODS_WITHOUT_RETURN_AND_PARAMETER_OF_TYPE_VALUE_SETTERS.Fetch(item);
        }

        static private OperationCache<List<ValueSetter<T>>, Type> GET_MARKED_INSTANCE_VALUES_OF_TYPE_VALUE_SETTERS = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_VALUES_OF_TYPE_VALUE_SETTERS", delegate(Type item) {
            return GetMarkedInstanceFieldsOfTypeValueSetters(item)
                .Append(GetMarkedInstanceMethodsWithoutReturnAndParameterOfTypeValueSetters(item))
                .ToList();
        });
        static public IEnumerable<ValueSetter<T>> GetMarkedInstanceValuesOfTypeValueSetters(Type item)
        {
            return GET_MARKED_INSTANCE_VALUES_OF_TYPE_VALUE_SETTERS.Fetch(item);
        }

        static private OperationCache<List<ValueGetter<T>>, Type> GET_MARKED_INSTANCE_VALUES_OF_TYPE_VALUE_GETTERS = ReflectionCache.Get().NewOperationCache("GET_MARKED_INSTANCE_VALUES_OF_TYPE_VALUE_GETTERS", delegate(Type item) {
            return GetMarkedInstanceFieldsOfTypeValueGetters(item)
                .Append(GetMarkedInstanceMethodsWithReturnAndNoEffectiveParametersValueGetters(item))
                .ToList();
        });
        static public IEnumerable<ValueGetter<T>> GetMarkedInstanceValuesOfTypeValueGetters(Type item)
        {
            return GET_MARKED_INSTANCE_VALUES_OF_TYPE_VALUE_GETTERS.Fetch(item);
        }
    }
}