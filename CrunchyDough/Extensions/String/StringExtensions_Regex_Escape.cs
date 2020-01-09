using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Regex_Escape
    {
        static public string RegexEscape(this string item)
        {
            return Regex.Escape(item);
        }
    }
}