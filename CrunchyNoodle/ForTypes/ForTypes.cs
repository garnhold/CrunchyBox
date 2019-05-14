using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class ForTypes
    {
        static private OperationCache<Type, Type, Type> GET_TYPE_FOR_TYPE = ReflectionCache.Get().NewOperationCache(delegate(Type attribute_type, Type type) {
            return Types.GetFilteredTypes(
                Filterer_Type.HasCustomForTypeAttributeOfType(attribute_type, type)
            ).FindLowestRated(t => t.GetCustomForTypeAttributeOfTypeTypeDistance(attribute_type, type));
        });
        static public Type GetTypeForType(Type attribute_type, Type type)
        {
            return GET_TYPE_FOR_TYPE.Fetch(attribute_type, type);
        }

        static public Type GetTypeForType<T>(Type type)
        {
            return GetTypeForType(typeof(T), type);
        }
    }
}