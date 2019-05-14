using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class TypeExtensions_Conversion
    {
        static private MethodInfo GetConversionMethodInternal(Type source_type, Type destination_type, string operator_name)
        {
            return source_type.GetStaticMethods().Append(destination_type.GetStaticMethods())
                .Narrow(m => m.Name == operator_name)
                .Narrow(m => m.ReturnType == destination_type)
                .Narrow(m => m.GetNumberEffectiveParameters() == 1)
                .Narrow(m => m.CanEffectiveParameterHold(0, source_type))
                .GetFirst();
        }

        static private OperationCache<MethodInfo, Type, Type> GET_IMPLICIT_CONVERSION_METHOD = ReflectionCache.Get().NewOperationCache(delegate(Type source_type, Type destination_type) {
            return GetConversionMethodInternal(source_type, destination_type, "op_Implicit");
        });
        static public MethodInfo GetImplicitConversionMethod(this Type item, Type destination_type)
        {
            return GET_IMPLICIT_CONVERSION_METHOD.Fetch(item, destination_type);
        }

        static private OperationCache<MethodInfo, Type, Type> GET_EXPLICIT_CONVERSION_METHOD = ReflectionCache.Get().NewOperationCache(delegate(Type source_type, Type destination_type) {
            return GetConversionMethodInternal(source_type, destination_type, "op_Explicit");
        });
        static public MethodInfo GetExplicitConversionMethod(this Type item, Type destination_type)
        {
            return GET_EXPLICIT_CONVERSION_METHOD.Fetch(item, destination_type);
        }
    }
}