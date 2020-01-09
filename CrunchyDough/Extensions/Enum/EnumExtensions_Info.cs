using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class EnumExtensions_Info
    {
        static public EnumInfo GetEnumInfo(this Enum item)
        {
            return EnumInfo.GetEnumInfo(item.GetType());
        }

        static public EnumValueInfo GetEnumValueInfo(this Enum item)
        {
            return item.GetEnumInfo().IfNotNull(i => i.GetEnumValueInfoByValue(item));
        }

        static public int GetEnumIndex(this Enum item)
        {
            return item.GetEnumValueInfo().IfNotNull(i => i.GetIndex());
        }

        static public string GetEnumName(this Enum item)
        {
            return item.GetEnumValueInfo().IfNotNull(i => i.GetName());
        }
    }
}