using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Float
    {
        static public bool TryParseFloat(this string item, out float value)
        {
            return float.TryParse(item.TrimAnySuffix("f", "F"), out value);
        }

        static public float ParseFloat(this string item, float default_value)
        {
            float value;

            if (item.TryParseFloat(out value))
                return value;

            return default_value;
        }
        static public float ParseFloat(this string item)
        {
            return item.ParseFloat(0);
        }
    }
}