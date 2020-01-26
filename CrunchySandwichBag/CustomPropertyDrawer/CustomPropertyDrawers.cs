using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    using Sandwich;
    
    static public class CustomPropertyDrawers
    {
        static private IEnumerable<Type> GetAllCustomPropertyDrawerTypes()
        {
            return Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<PropertyDrawer>(),
                Filterer_Type.HasCustomAttributeOfType<CustomPropertyDrawer>(false)
            );
        }

        static private OperationCache<KeyValuePair<Type, CustomPropertyDrawer>[]> GET_ALL_CUSTOM_PROPERTY_DRAWER_TYPES_WITH_ATTRIBUTE = ReflectionCache.Get().NewOperationCache("GET_ALL_CUSTOM_PROPERTY_DRAWER_TYPES_WITH_ATTRIBUTE", delegate() {
            return GetAllCustomPropertyDrawerTypes().Convert(type => KeyValuePair.New(
                type,
                type.GetCustomAttributeOfType<CustomPropertyDrawer>(false)
            )).ToArray();
        });
        static private IEnumerable<KeyValuePair<Type, CustomPropertyDrawer>> GetAllCustomPropertyDrawerTypesWithAttribute()
        {
            return GET_ALL_CUSTOM_PROPERTY_DRAWER_TYPES_WITH_ATTRIBUTE.Fetch();
        }

        static private OperationCache<Type, Type> GET_PROPERTY_DRAWER_TYPE = ReflectionCache.Get().NewOperationCache("GET_PROPERTY_DRAWER_TYPE", delegate(Type type) {
            return GetAllCustomPropertyDrawerTypesWithAttribute()
                .Narrow(p => p.Value.CanHandleType(type))
                .FindLowestRated(p => type.GetTypeDistance(p.Value.GetHandledType()))
                .IfNotNull(p => p.Key);
        });
        static private Type GetPropertyDrawerType(Type type)
        {
            return GET_PROPERTY_DRAWER_TYPE.Fetch(type);
        }

        static private OperationCache<PropertyDrawer, Type> GET_PROPERTY_DRAWER = ReflectionCache.Get().NewOperationCache("GET_PROPERTY_DRAWER", delegate(Type type) {
            return GetPropertyDrawerType(type).IfNotNull(t => t.CreateInstance<PropertyDrawer>());
        });
        static public PropertyDrawer GetPropertyDrawer(Type type)
        {
            return GET_PROPERTY_DRAWER.Fetch(type);
        }
    }
}