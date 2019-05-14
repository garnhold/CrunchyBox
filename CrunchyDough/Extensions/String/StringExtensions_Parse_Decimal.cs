using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_Decimal
    {
        static public bool TryParseDecimal(this string item, out decimal value)
        {
            return decimal.TryParse(item, out value);
        }

        static public decimal ParseDecimal(this string item, decimal default_value)
        {
            decimal value;

            if (item.TryParseDecimal(out value))
                return value;

            return default_value;
        }
        static public decimal ParseDecimal(this string item)
        {
            return item.ParseDecimal(0.0m);
        }
    }
}