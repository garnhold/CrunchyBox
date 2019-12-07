using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Double
    {
        static public bool TryParseDouble(this string item, out double value)
        {
            return double.TryParse(item, out value);
        }

        static public double ParseDouble(this string item, double default_value)
        {
            double value;

            if (item.TryParseDouble(out value))
                return value;

            return default_value;
        }
        static public double ParseDouble(this string item)
        {
            return item.ParseDouble(0.0);
        }
    }
}