using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_DateTime
    {
        static public bool TryParseDateTime(this string item, out DateTime value)
        {
            return DateTime.TryParse(item, out value);
        }

        static public DateTime ParseDateTime(this string item, DateTime default_value)
        {
            DateTime value;

            if (item.TryParseDateTime(out value))
                return value;

            return default_value;
        }
        static public DateTime ParseDateTime(this string item)
        {
            return item.ParseDateTime(DateTime.MinValue);
        }
    }
}