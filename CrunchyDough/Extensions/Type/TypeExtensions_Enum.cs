using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Enum
    {
        static public bool IsEnumType(this Type item)
        {
            if (item.IsEnum)
                return true;

            return false;
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
    }
}