using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Regex_GetGroup
    {
        static public string RegexGetGroup(this string item, Regex pattern, int group)
        {
            return item.RegexMatch(pattern).Groups[group].Value;
        }
        static public string RegexGetGroup(this string item, string pattern, int group)
        {
            return item.RegexGetGroup(pattern.CompileRegexFromPattern(), group);
        }
        static public string RegexGetGroup(this string item, CachedRegex pattern, int group)
        {
            return item.RegexMatch(pattern).Groups[group].Value;
        }

        static public string RegexGetGroup(this string item, Regex pattern, string group)
        {
            return item.RegexMatch(pattern).Groups[group].Value;
        }
        static public string RegexGetGroup(this string item, string pattern, string group)
        {
            return item.RegexGetGroup(pattern.CompileRegexFromPattern(), group);
        }
        static public string RegexGetGroup(this string item, CachedRegex pattern, string group)
        {
            return item.RegexMatch(pattern).Groups[group].Value;
        }
    }
}