using System;

namespace CrunchyDough
{
    static public class IntExtensions_Enum
    {
        static public bool TryConvertIndexToEnum(this int item, Type type, out Enum value)
        {
            return type.GetEnumInfo().TryConvertIndexToValue(item, out value);
        }

        static public Enum ConvertIndexToEnum(this int item, Type type)
        {
            Enum value;

            item.TryConvertIndexToEnum(type, out value);
            return value;
        }
    }
}