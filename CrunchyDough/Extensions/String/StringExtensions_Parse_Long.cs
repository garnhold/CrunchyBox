using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_Long
    {
        static public bool TryParseLong(this string item, out long value)
        {
            return long.TryParse(item.TrimAnySuffix("l", "L"), out value);
        }

        static public long ParseLong(this string item, long default_value)
        {
            long value;

            if (item.TryParseLong(out value))
                return value;

            return default_value;
        }
        static public long ParseLong(this string item)
        {
            return item.ParseLong(0);
        }
    }
}