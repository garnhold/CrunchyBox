using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_Short
    {
        static public bool TryParseShort(this string item, out short value)
        {
            return short.TryParse(item, out value);
        }

        static public short ParseShort(this string item, short default_value)
        {
            short value;

            if (item.TryParseShort(out value))
                return value;

            return default_value;
        }
        static public short ParseShort(this string item)
        {
            return item.ParseShort(0);
        }
    }
}