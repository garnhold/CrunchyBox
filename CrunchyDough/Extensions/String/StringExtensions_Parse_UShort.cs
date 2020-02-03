using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_UShort
    {
        static public bool TryParseUShort(this string item, out ushort value)
        {
            return ushort.TryParse(item, out value);
        }

        static public ushort ParseUShort(this string item, ushort default_value)
        {
            ushort value;

            if (item.TryParseUShort(out value))
                return value;

            return default_value;
        }
        static public ushort ParseUShort(this string item)
        {
            return item.ParseUShort(0);
        }
    }
}