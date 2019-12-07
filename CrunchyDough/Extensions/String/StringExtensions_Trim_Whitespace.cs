using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Trim_Whitespace
    {
        static public string TrimLeadingWhitespace(this string item)
        {
            return item.RegexRemove("^[ \t\r\n]+");
        }

        static public string TrimTrailingWhitespace(this string item)
        {
            return item.RegexRemove("[ \t\r\n]+$");
        }

        static public string TrimWhitespace(this string item)
        {
            return item.TrimLeadingWhitespace().TrimTrailingWhitespace();
        }
    }
}