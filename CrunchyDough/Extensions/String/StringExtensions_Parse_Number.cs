using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_Number
    {
        static public bool TryParseNumber(this string item, out string value)
        {
            if (item.RegexIsMatch("^(\\-|\\+)?[0-9]+(\\.[0-9]+)?$"))
            {
                value = item;
                return true;
            }

            value = "0";
            return false;
        }

        static public string ParseNumber(this string item, string default_value)
        {
            string value;

            if (item.TryParseNumber(out value))
                return value;

            return default_value;
        }
        static public string ParseNumber(this string item)
        {
            return item.ParseNumber("0");
        }
    }
}