using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_UInt
    {
        static public bool TryParseUInt(this string item, out uint value)
        {
            return uint.TryParse(item, out value);
        }

        static public uint ParseUInt(this string item, uint default_value)
        {
            uint value;

            if (item.TryParseUInt(out value))
                return value;

            return default_value;
        }
        static public uint ParseUInt(this string item)
        {
            return item.ParseUInt(0);
        }
    }
}