using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Int
    {
        static public bool TryParseInt(this string item, out int value)
        {
            return int.TryParse(item, out value);
        }

        static public int ParseInt(this string item, int default_value)
        {
            int value;

            if (item.TryParseInt(out value))
                return value;

            return default_value;
        }
        static public int ParseInt(this string item)
        {
            return item.ParseInt(0);
        }
    }
}