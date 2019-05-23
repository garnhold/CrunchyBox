using System;

namespace CrunchyDough
{
    static public class EnumInfoExtensions_Get
    {
        static public EnumValueInfo GetEnumValueInfoByIndex(this EnumInfo item, int index)
        {
            EnumValueInfo info;

            item.TryGetEnumValueInfoByIndex(index, out info);
            return info;
        }

        static public EnumValueInfo GetEnumValueInfoByName(this EnumInfo item, string name)
        {
            EnumValueInfo info;

            item.TryGetEnumValueInfoByName(name, out info);
            return info;
        }

        static public EnumValueInfo GetEnumValueInfoByValue(this EnumInfo item, Enum value)
        {
            EnumValueInfo info;

            item.TryGeEnumValuetInfoByValue(value, out info);
            return info;
        }

        static public EnumValueInfo GetEnumValueInfoByLongValue(this EnumInfo item, long value)
        {
            EnumValueInfo info;

            item.TryGetEnumValueInfoByLongValue(value, out info);
            return info;
        }
    }
}