using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_BasicType
    {
        static private OperationCache<BasicType, Type> GET_BASIC_TYPE = ReflectionCache.Get().NewOperationCache("GET_BASIC_TYPE", delegate(Type type) {
            if (type == typeof(void)) return BasicType.Void;

            if (type == typeof(bool)) return BasicType.Bool;

            if (type == typeof(byte)) return BasicType.Byte;
            if (type == typeof(short)) return BasicType.Short;
            if (type == typeof(int)) return BasicType.Int;
            if (type == typeof(long)) return BasicType.Long;

            if (type == typeof(float)) return BasicType.Float;
            if (type == typeof(double)) return BasicType.Double;
            if (type == typeof(decimal)) return BasicType.Decimal;

            if (type == typeof(char)) return BasicType.Char;
            if (type == typeof(string)) return BasicType.String;

            if (type.IsEnum()) return BasicType.Enum;
            if (type.IsStruct()) return BasicType.Struct;
            if (type.IsReferenceType()) return BasicType.Class;

            throw new UnaccountedBranchException("type", type);
        });
        static public BasicType GetBasicType(this Type item)
        {
            return GET_BASIC_TYPE.Fetch(item);
        }
    }
}