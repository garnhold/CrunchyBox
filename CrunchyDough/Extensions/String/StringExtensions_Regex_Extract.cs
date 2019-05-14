using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CrunchyDough
{
    static public class StringExtensions_Regex_Extract
    {
        static public string RegexExtract(this string item, Regex pattern, int group, out string capture)
        {
            return item.ExtractMatch(item.RegexMatch(pattern), group, out capture);
        }
        static public string RegexExtract(this string item, string pattern, int group, out string capture)
        {
            return item.RegexExtract(pattern.CompileRegexFromPattern(), group, out capture);
        }
        static public string RegexExtract(this string item, CachedRegex pattern, int group, out string capture)
        {
            return item.ExtractMatch(item.RegexMatch(pattern), group, out capture);
        }

        static public string RegexExtract(this string item, Regex pattern, string group, out string capture)
        {
            return item.ExtractMatch(item.RegexMatch(pattern), group, out capture);
        }
        static public string RegexExtract(this string item, string pattern, string group, out string capture)
        {
            return item.RegexExtract(pattern.CompileRegexFromPattern(), group, out capture);
        }
        static public string RegexExtract(this string item, CachedRegex pattern, string group, out string capture)
        {
            return item.ExtractMatch(item.RegexMatch(pattern), group, out capture);
        }
    }
}