using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Escape
    {
        static public string EscapePattern(this string item, string to_escape, string escape)
        {
            return item.RegexReplace("(?<OUTPUT>(" + to_escape + ")|" + escape.RegexEscape() + ")", delegate(Match match) {
                return escape + match.Groups["OUTPUT"].Value;
            });
        }

        static public string EscapeString(this string item, string to_escape, string escape)
        {
            return item.EscapePattern(to_escape.RegexEscape(), escape);
        }

        static public string EscapeCharacters(this string item, string to_escape, string escape)
        {
            return item.EscapePattern("[" + to_escape.RegexEscape() + "]", escape);
        }

        static public string UnescapePattern(this string item, string to_escape, string escape)
        {
            return item.RegexReplace("(" + escape.RegexEscape() + "(?<OUTPUT>" + to_escape + "))", delegate(Match match) {
                return match.Groups["OUTPUT"].Value;
            });
        }

        static public string UnescapeString(this string item, string to_escape, string escape)
        {
            return item.UnescapePattern(to_escape.RegexEscape(), escape);
        }

        static public string UnescapeCharacters(this string item, string to_escape, string escape)
        {
            return item.UnescapePattern("[" + to_escape.RegexEscape() + "]", escape);
        }
    }
}