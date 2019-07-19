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
        static private readonly OperationCache<FieldInfoEX, Type, int> RESOLVE_FIELD = ReflectionCache.Get().NewOperationCache(delegate(Type type, int metadata_token) {
            return type.GetMemberFields().FindFirst(f => f.MetadataToken == metadata_token);
        });
        static public FieldInfoEX ResolveField(this Type item, int metadata_token)
        {
            return RESOLVE_FIELD.Fetch(item, metadata_token);
        }

        static private readonly OperationCache<MethodInfoEX, Type, int> RESOLVE_METHOD = ReflectionCache.Get().NewOperationCache(delegate(Type type, int metadata_token) {
            return type.GetTechnicalMemberMethods().FindFirst(f => f.MetadataToken == metadata_token);
        });
        static public MethodInfoEX ResolveMethod(this Type item, int metadata_token)
        {
            return RESOLVE_METHOD.Fetch(item, metadata_token);
        }
    }
}