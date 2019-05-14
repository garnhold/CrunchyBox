using System;

using System.Text.RegularExpressions;

namespace CrunchyDough
{
    static public class StringExtensions_Match
    {
        static public string ExtractMatch(this string item, Match match, int group, out string capture)
        {
            return item.ExtractGroup(match.Groups[group], out capture);
        }

        static public string ExtractMatch(this string item, Match match, string group, out string capture)
        {
            return item.ExtractGroup(match.Groups[group], out capture);
        }
    }
}