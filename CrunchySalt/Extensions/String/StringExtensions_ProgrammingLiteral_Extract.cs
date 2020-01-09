using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class StringExtensions_ProgrammingLiteral_Extract
    {
        static public string ExtractStringValueFromLiteralString(this string item, string delimiter)
        {
            if (item.TryTrimPrefixAndSuffix(delimiter, out item))
                return item.ExpandEscapeSequences();

            return "";
        }

        static public string ExtractStringValueFromLiteralString(this string item)
        {
            if (item.StartsWith("\""))
                return item.ExtractStringValueFromLiteralString("\"");

            if (item.StartsWith("'"))
                return item.ExtractStringValueFromLiteralString("'");

            return "";
        }
    }
}