using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class TypeExtensions_Resolve
    {
        static private readonly OperationCache<Dictionary<int, FieldInfoEX>, Type> FIELDS_BY_METADATA_TOKEN = ReflectionCache.Get().NewOperationCache("FIELDS_BY_METADATA_TOKEN", delegate(Type type) {
            return type.GetMemberFields().ToDictionaryValues(f => f.MetadataToken);
        });
        static public FieldInfoEX ResolveField(this Type item, int metadata_token)
        {
            if (item.IsNonGenericClass())
                return item.Module.ResolveField(metadata_token).GetFieldInfoEX();

            return FIELDS_BY_METADATA_TOKEN.Fetch(item).GetValue(metadata_token);
        }

        static private readonly OperationCache<Dictionary<int, PropertyInfoEX>, Type> PROPERTYS_BY_METADATA_TOKEN = ReflectionCache.Get().NewOperationCache("PROPERTYS_BY_METADATA_TOKEN", delegate(Type type) {
            return type.GetMemberPropertys().ToDictionaryValues(p => p.MetadataToken);
        });
        static public PropertyInfoEX ResolveProperty(this Type item, int metadata_token)
        {
            return PROPERTYS_BY_METADATA_TOKEN.Fetch(item).GetValue(metadata_token);
        }

        static private readonly OperationCache<Dictionary<int, MethodInfoEX>, Type> METHODS_BY_METADATA_TOKEN = ReflectionCache.Get().NewOperationCache("METHODS_BY_METADATA_TOKEN", delegate(Type type) {
            return type.GetTechnicalMemberMethods().ToDictionaryValues(m => m.MetadataToken);
        });
        static public MethodInfoEX ResolveMethod(this Type item, int metadata_token)
        {
            if (item.IsNonGenericClass())
                return ((MethodInfo)item.Module.ResolveMethod(metadata_token)).GetMethodInfoEX();

            return METHODS_BY_METADATA_TOKEN.Fetch(item).GetValue(metadata_token);
        }
    }
}