using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_String
    {
        static public bool TryParseString(this string item, out string value)
        {
            value = item;
            return true;
        }

        static public string ParseString(this string item, string default_value)
        {
            string value;

            if (item.TryParseString(out value))
                return value;

            return default_value;
        }
        static public string ParseString(this string item)
        {
            return item.ParseString("");
        }
    }
}