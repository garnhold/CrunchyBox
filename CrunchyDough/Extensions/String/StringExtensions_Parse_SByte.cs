using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_SByte
    {
        static public bool TryParseSByte(this string item, out sbyte value)
        {
            return sbyte.TryParse(item, out value);
        }

        static public sbyte ParseSByte(this string item, sbyte default_value)
        {
            sbyte value;

            if (item.TryParseSByte(out value))
                return value;

            return default_value;
        }
        static public sbyte ParseSByte(this string item)
        {
            return item.ParseSByte(0);
        }
    }
}