using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Enum
    {
        static public Enum MakeEnumValue(this Type item, long value)
        {
            return (Enum)Enum.ToObject(item, value);
        }

        static public bool IsEnumType(this Type item)
        {
            if (item.IsEnum)
                return true;

            return false;
        }

        static public Type GetEnumUnderlyingType(this Type item)
        {
            return Enum.GetUnderlyingType(item);
        }

        static public bool IsEnumFlagType(this Type item)
        {
            if (item.IsEnumType())
            {
                if (item.HasCustomAttributeOfType<FlagsAttribute>(true))
                    return true;
            }

            return false;
        }

        static public EnumInfo GetEnumInfo(this Type item)
        {
            return EnumInfo.GetEnumInfo(item);
        }

        static public EnumValueInfo GetEnumValueInfoByIndex(this Type item, int index)
        {
            return item.GetEnumInfo().IfNotNull(i => i.GetEnumValueInfoByIndex(index));
        }
        static public Enum GetEnumValueByIndex(this Type item, int index)
        {
            return item.GetEnumValueInfoByIndex(index).IfNotNull(i => i.GetValue());
        }

        static public EnumValueInfo GetEnumValueInfoByName(this Type item, string name)
        {
            return item.GetEnumInfo().IfNotNull(i => i.GetEnumValueInfoByName(name));
        }
        static public Enum GetEnumValueByName(this Type item, string name)
        {
            return item.GetEnumValueInfoByName(name).IfNotNull(i => i.GetValue());
        }
    }
}