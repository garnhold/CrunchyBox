using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_Enum
    {
        static public bool TryParseEnum(this string item, Type type, out Enum value)
        {
            return type.GetEnumInfo().TryConvertTextToValue(item, out value);
        }

        static public Enum ParseEnum(this string item, Type type)
        {
            Enum value;

            item.TryParseEnum(type, out value);
            return value;
        }
    }
}