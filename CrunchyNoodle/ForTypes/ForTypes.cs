using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class ForTypes
    {
        static private OperationCache<List<Type>, Type, Type> GET_ALL_TYPES_FOR_TYPE = ReflectionCache.Get().NewOperationCache("GET_ALL_TYPES_FOR_TYPE", delegate(Type attribute_type, Type type) {
            return Types.GetFilteredTypes(
                Filterer_Type.HasCustomForTypeAttributeOfType(attribute_type, type)
            ).ToList();
        });
        static public IEnumerable<Type> GetAllTypesForType(Type attribute_type, Type type)
        {
            return GET_ALL_TYPES_FOR_TYPE.Fetch(attribute_type, type);
        }
        static public IEnumerable<Type> GetAllTypesForType<T>(Type type)
        {
            return GetAllTypesForType(typeof(T), type);
        }

        static private OperationCache<List<Type>, Type, Type> GET_BEST_TYPES_FOR_TYPE = ReflectionCache.Get().NewOperationCache("GET_BEST_TYPES_FOR_TYPE", delegate(Type attribute_type, Type type) {
            return GetAllTypesForType(attribute_type, type)
                .FindAllLowestRated(t => t.GetCustomForTypeAttributeOfTypeTypeDistance(attribute_type, type))
                .ToList();
        });
        static public IEnumerable<Type> GetBestTypesForType(Type attribute_type, Type type)
        {
            return GET_BEST_TYPES_FOR_TYPE.Fetch(attribute_type, type);
        }
        static public IEnumerable<Type> GetBestTypesForType<T>(Type type)
        {
            return GetBestTypesForType(typeof(T), type);
        }

        static public Type GetBestTypeForType(Type attribute_type, Type type)
        {
            return GetBestTypesForType(attribute_type, type).GetFirst();
        }
        static public Type GetBestTypeForType<T>(Type type)
        {
            return GetBestTypeForType(typeof(T), type);
        }
    }
}