using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Treatment_Primitive
    {
        static public bool IsString(this Type item)
        {
            if (item == typeof(string))
                return true;

            return false;
        }

        static public bool IsBool(this Type item)
        {
            if (item == typeof(bool))
                return true;

            return false;
        }

        static public bool IsReal(this Type item)
        {
            if (
                item == typeof(decimal) ||
                item == typeof(double) ||
                item == typeof(float))
                return true;

            return false;
        }

        static public bool IsInteger(this Type item)
        {
            if (
                item == typeof(long) ||
                item == typeof(int) ||
                item == typeof(short) ||
                item == typeof(byte))
                return true;

            return false;
        }

        static public bool IsNumeric(this Type item)
        {
            if (item.IsReal() || item.IsInteger())
                return true;

            return false;
        }

        static public bool IsEnum(this Type item)
        {
            if (item.IsEnum)
                return true;

            return false;
        }

        static public bool IsPrimitive(this Type item)
        {
            if (item.IsString() || item.IsBool() || item.IsNumeric() || item.IsEnum())
                return true;

            return false;
        }
    }
}