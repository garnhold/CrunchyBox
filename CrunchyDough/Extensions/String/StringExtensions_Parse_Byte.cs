using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Byte
    {
        static public bool TryParseByte(this string item, out byte value)
        {
            return byte.TryParse(item, out value);
        }

        static public byte ParseByte(this string item, byte default_value)
        {
            byte value;

            if (item.TryParseByte(out value))
                return value;

            return default_value;
        }
        static public byte ParseByte(this string item)
        {
            return item.ParseByte(0);
        }
    }
}