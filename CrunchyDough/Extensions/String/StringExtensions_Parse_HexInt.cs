using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_HexInt
    {
        static public bool TryParseHexInt(this string item, out int value)
        {
            return int.TryParse(
                item.TrimAnyPrefix("0x", "0X"),
                System.Globalization.NumberStyles.HexNumber,
                System.Globalization.CultureInfo.InvariantCulture,
                out value
            );
        }

        static public int ParseHexInt(this string item, int default_value)
        {
            int value;

            if (item.TryParseHexInt(out value))
                return value;

            return default_value;
        }
        static public int ParseHexInt(this string item)
        {
            return item.ParseHexInt(0);
        }
    }
}