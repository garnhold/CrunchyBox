using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_EscapeSequence
    {
        static public string CompressEscapeSequences(this string item)
        {
            return item.RegexReplace("([^\\P{C}]|\'|\"|\\\\|\\?)", delegate(Match match) {
                char character = match.Value[0];

                switch (character)
                {
                    case '\a': return "\\a";
                    case '\b': return "\\b";
                    case '\f': return "\\f";
                    case '\n': return "\\n";
                    case '\r': return "\\r";
                    case '\t': return "\\t";
                    case '\v': return "\\v";

                    case '\'': return "\\'";
                    case '\"': return "\\\"";
                    case '\\': return "\\\\";
                    case '?': return "\\?";
                }

                return "\\x" + character.GetValue().ToString("X4");
            });
        }

        static public string ExpandEscapeSequences(this string item)
        {
            return item.RegexReplace("(\\\\x([A-Fa-f0-9]{4})|\\\\(.))", delegate(Match match) {
                if (match.Groups[2].Success)
                    return ((char)match.Groups[2].Value.ParseHexInt()).ToString();

                char character = match.Groups[3].Value[0];
                switch (character)
                {
                    case 'a': return "\a";
                    case 'b': return "\b";
                    case 'f': return "\f";
                    case 'n': return "\n";
                    case 'r': return "\r";
                    case 't': return "\t";
                    case 'v': return "\v";
                }

                return character.ToString();
            });
        }
    }
}