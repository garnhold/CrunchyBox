using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Number
    {
        static public bool TryParseNumber(this string item, out object value)
        {
            if (item.Contains("."))
            {
                decimal cast;

                if (item.TryParseDecimal(out cast))
                {
                    value = cast;
                    return true;
                }
            }
            else
            {
                long cast;

                if (item.TryParseLong(out cast))
                {
                    value = cast.ShrinkFit();
                    return true;
                }
            }

            if (item.RegexIsMatch("^(\\-|\\+)?[0-9]+(\\.[0-9]+)?$"))
            {
                value = item;
                return true;
            }

            value = 0;
            return false;
        }

        static public object ParseNumber(this string item, object default_value)
        {
            object value;

            if (item.TryParseNumber(out value))
                return value;

            return default_value;
        }
        static public object ParseNumber(this string item)
        {
            return item.ParseNumber(0);
        }
    }
}