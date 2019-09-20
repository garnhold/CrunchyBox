using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Treatment_Basic
    {
        static public bool IsVoidType(this Type item)
        {
            if (item == typeof(void))
                return true;

            return false;
        }

        static public bool IsNotVoidType(this Type item)
        {
            if (item.IsVoidType() == false)
                return true;

            return false;
        }

        static public bool IsValueType(this Type item)
        {
            if (item.IsNotVoidType())
            {
                if (item.IsValueType)
                    return true;
            }

            return false;
        }
        static public bool IsTypicalValueType(this Type item)
        {
            if (item.IsValueType() || item.IsString() || item.IsEnum())
                return true;

            return false;
        }

        static public bool IsReferenceType(this Type item)
        {
            if (item.IsNotVoidType())
            {
                if(item.IsValueType == false)
                    return true;
            }

            return false;
        }
        static public bool IsTypicalReferenceType(this Type item)
        {
            if (item.IsReferenceType() && item.IsString() == false && item.IsEnum() == false)
                return true;

            return false;
        }

        static public bool IsStruct(this Type item)
        {
            if (item.IsValueType())
            {
                if (item.IsPrimitive == false && item.IsEnum() == false)
                    return true;
            }

            return false;
        }

        static public bool IsClass(this Type item)
        {
            if (item.IsTypicalReferenceType())
                return true;

            return false;
        }

        static public bool IsNullable(this Type item)
        {
            if (item.IsReferenceType())
                return true;

            return false;
        }

        static public bool IsNestedClass(this Type item)
        {
            if (item.IsNested)
                return true;

            return false;
        }
        static public bool IsNonNestedClass(this Type item)
        {
            if (item.IsNestedClass() == false)
                return true;

            return false;
        }
    }
}