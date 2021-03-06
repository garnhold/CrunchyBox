using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public partial class ExtensionMethods
    {
        static private CompileTimeCache<List<MethodInfoEX>> GET_ALL_EXTENSION_METHODS = ReflectionCache.Get().NewCompileTimeCache("GET_ALL_EXTENSION_METHODS", MethodInfoEXListHusker.INSTANCE, delegate() {
            return Assemblys.GetAllInspectedAssemblys()
                .Narrow(a => a.ContainsExtensionTypes())

                .Convert(a => a.GetAllDefinedTypes())
                .Flatten()
                .Narrow(t => t.IsExtensionClass())

                .Convert(t => t.GetStaticMethods())
                .Flatten()
                .Narrow(m => m.IsExtensionMethod())
                .Skip(m => m.IsGenericTypelessMethod())

                .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetAllExtensionMethods()
        {
            return GET_ALL_EXTENSION_METHODS.Fetch();
        }

        static private OperationCache<Dictionary<Type, List<MethodInfoEX>>> GET_IMMEDIATE_EXTENSION_METHODS_BY_TYPE = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_EXTENSION_METHODS_BY_TYPE", delegate() {
            return GetAllExtensionMethods().ToMultiDictionary(m => m.GetMethodEffectiveType());
        });
        static public IEnumerable<MethodInfoEX> GetImmediateExtensionMethodsForType(Type type)
        {
            return GET_IMMEDIATE_EXTENSION_METHODS_BY_TYPE.Fetch().GetValues(type);
        }

        static private OperationCache<List<MethodInfoEX>, Type> GET_ALL_EXTENSION_METHODS_FOR_TYPE = ReflectionCache.Get().NewOperationCache("GET_ALL_EXTENSION_METHODS_FOR_TYPE", delegate(Type type) {
            return type.GetTypeAndAllBaseTypesAndInterfaces()
                .Convert(t => GetImmediateExtensionMethodsForType(t))
                .Flatten()
                .ToList();
        });
        static public IEnumerable<MethodInfoEX> GetAllExtensionMethodsForType(Type type)
        {
            return GET_ALL_EXTENSION_METHODS_FOR_TYPE.Fetch(type);
        }
    }
}