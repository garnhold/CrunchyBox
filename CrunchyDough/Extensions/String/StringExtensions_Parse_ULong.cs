using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_ULong
    {
        static public bool TryParseULong(this string item, out ulong value)
        {
            return ulong.TryParse(item.TrimAnySuffix("l", "L"), out value);
        }

        static public ulong ParseULong(this string item, ulong default_value)
        {
            ulong value;

            if (item.TryParseULong(out value))
                return value;

            return default_value;
        }
        static public ulong ParseULong(this string item)
        {
            return item.ParseULong(0);
        }
    }
}