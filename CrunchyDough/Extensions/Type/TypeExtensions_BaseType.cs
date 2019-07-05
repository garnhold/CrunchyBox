using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_BaseType
    {
        static private OperationCache<List<Type>, Type> GET_ALL_BASE_TYPES = ReflectionCache.Get().NewOperationCache(delegate(Type item) {
            return item.Traverse(t => t.BaseType)
                .ToList();
        });
        static public IEnumerable<Type> GetAllBaseTypes(this Type item)
        {
            return GET_ALL_BASE_TYPES.Fetch(item);
        }

        static private OperationCache<List<Type>, Type> GET_TYPE_AND_ALL_BASE_TYPES = ReflectionCache.Get().NewOperationCache(delegate(Type item) {
            return item.GetAllBaseTypes()
                .Prepend(item)
                .ToList();
        });
        static public IEnumerable<Type> GetTypeAndAllBaseTypes(this Type item)
        {
            return GET_TYPE_AND_ALL_BASE_TYPES.Fetch(item);
        }

        static private OperationCache<List<Type>, Type, DetailDirection> GET_TYPE_AND_ALL_BASE_TYPES_AND_INTERFACES = ReflectionCache.Get().NewOperationCache(delegate(Type item, DetailDirection direction) {
            return item.TraverseWebWithSelf(i => i.GetInterfaces().Prepend(i.BaseType))
                .ModifySpecificToBasicSequence(direction)
                .ToList();
        });
        static public IEnumerable<Type> GetTypeAndAllBaseTypesAndInterfaces(this Type item, DetailDirection direction)
        {
            return GET_TYPE_AND_ALL_BASE_TYPES_AND_INTERFACES.Fetch(item, direction);
        }
        static public IEnumerable<Type> GetTypeAndAllBaseTypesAndInterfaces(this Type item)
        {
            return item.GetTypeAndAllBaseTypesAndInterfaces(DetailDirection.SpecificToBasic);
        }

        static private OperationCache<List<Type>, Type, DetailDirection> GET_ALL_BASE_TYPES_AND_INTERFACES = ReflectionCache.Get().NewOperationCache(delegate(Type item, DetailDirection direction) {
            return item.GetTypeAndAllBaseTypesAndInterfaces(direction)
                .Skip(item)
                .ToList();
        });
        static public IEnumerable<Type> GetAllBaseTypesAndInterfaces(this Type item, DetailDirection direction)
        {
            return GET_ALL_BASE_TYPES_AND_INTERFACES.Fetch(item, direction);
        }
        static public IEnumerable<Type> GetAllBaseTypesAndInterfaces(this Type item)
        {
            return item.GetAllBaseTypesAndInterfaces(DetailDirection.SpecificToBasic);
        }
    }
}