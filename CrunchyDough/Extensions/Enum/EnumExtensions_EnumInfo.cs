using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class EnumExtensions_EnumInfo
    {
        static public EnumInfo GetEnumInfo(this Enum item)
        {
            return EnumInfo.GetEnumInfo(item.GetType());
        }
    }
}