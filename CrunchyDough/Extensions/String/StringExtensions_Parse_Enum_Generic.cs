using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Enum_Generic
    {
        static public bool TryParseEnum<T>(this string item, out T value)
        {
            return StringExtensions_Parse_Enum_Internal<T>.TryParseEnum(item, out value);
        }

        static public T ParseEnum<T>(this string item)
        {
            return StringExtensions_Parse_Enum_Internal<T>.ParseEnum(item);
        }
    }
}