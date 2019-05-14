using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_Enum_Internal<T>
    {
        static private EnumInfo ENUM_INFO = typeof(T).GetEnumInfo();

        static public bool TryParseEnum(string item, out T value)
        {
            return ENUM_INFO.TryConvertTextToValue<T>(item, out value);
        }

        static public T ParseEnum(string item)
        {
            T value;

            TryParseEnum(item, out value);
            return value;
        }
    }
}