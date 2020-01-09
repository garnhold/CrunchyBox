using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Regex_Split
    {
        static public string[] RegexSplit(this string item, Regex pattern) { return item.RegexSplit(pattern, int.MaxValue); }
        static public string[] RegexSplit(this string item, Regex pattern, int count)
        {
            return pattern.Split(item ?? "", count);
        }
        static public string[] RegexSplit(this string item, string pattern) { return item.RegexSplit(pattern, int.MaxValue); }
        static public string[] RegexSplit(this string item, string pattern, int count)
        {
            return item.RegexSplit(pattern.GetRegexByPattern(), count);
        }
        static public string[] RegexSplit(this string item, CachedRegex pattern)
        {
            return pattern.Split(item);
        }
    }
}