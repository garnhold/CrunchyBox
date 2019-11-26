using System;
using System.Text;
using System.Text.RegularExpressions;

using CrunchyDough;

namespace CrunchySalt
{
    static public class StringExtensions_ProgrammingEntityName_StyleForDisplay
    {
        static public string StyleEntityForDisplay(this string item)
        {
            item = item.TrimPrefix("m_");

            item = item.RegexReplace("[a-z][A-Z]", delegate(Match match) {
                return match.Value[0] + " " + match.Value[1];
            });

            item = item.RegexReplace("([A-Z])([A-Z][a-z])", delegate(Match match) {
                return match.Groups[1] + " " + match.Groups[2];
            });

            item = item.RegexReplace("(^|_)([A-Za-z])", delegate(Match match) {
                if (match.Groups[1].Value.IsVisible())
                    return " " + match.Groups[2].Value.ToUpper();

                return match.Groups[2].Value.ToUpper();
            });

            return item;
        }
    }
}