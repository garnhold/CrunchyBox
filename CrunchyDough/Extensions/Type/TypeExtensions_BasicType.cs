using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_BasicType
    {
        static public BasicType GetBasicType(this Type item)
        {
            if (item == typeof(bool)) return BasicType.Bool;

            if (item == typeof(byte)) return BasicType.Byte;
            if (item == typeof(short)) return BasicType.Short;
            if (item == typeof(int)) return BasicType.Int;
            if (item == typeof(long)) return BasicType.Long;

            if (item == typeof(float)) return BasicType.Float;
            if (item == typeof(double)) return BasicType.Double;
            if (item == typeof(decimal)) return BasicType.Decimal;

            if (item == typeof(char)) return BasicType.Char;
            if (item == typeof(string)) return BasicType.String;

            if (item.IsStruct()) return BasicType.Struct;
            if (item.IsEnum()) return BasicType.Enum;
            if (item.IsReferenceType()) return BasicType.Class;

            throw new UnaccountedBranchException("item", item);
        }
    }
}