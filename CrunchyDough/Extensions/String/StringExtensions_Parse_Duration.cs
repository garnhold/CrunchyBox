using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_Duration
    {
        static public bool TryParseDuration(this string item, out Duration value)
        {
            return Duration.TryParse(item, out value);
        }

        static public Duration ParseDuration(this string item, Duration default_value)
        {
            Duration value;

            if (item.TryParseDuration(out value))
                return value;

            return default_value;
        }
        static public Duration ParseDuration(this string item)
        {
            return item.ParseDuration(default(Duration));
        }
    }
}