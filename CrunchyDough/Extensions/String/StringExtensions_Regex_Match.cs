using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Regex_Match
    {
        static public bool RegexIsMatch(this string item, Regex pattern)
        {
            return pattern.IsMatch(item ?? "");
        }
        static public bool RegexIsMatch(this string item, string pattern)
        {
            return item.RegexIsMatch(pattern.GetRegexByPattern());
        }
        static public bool RegexIsMatch(this string item, CachedRegex pattern)
        {
            return pattern.IsMatch(item);
        }

        static public Match RegexMatch(this string item, Regex pattern) { return item.RegexMatch(pattern, 0); }
        static public Match RegexMatch(this string item, Regex pattern, int start_index)
        {
            return pattern.Match(item ?? "", start_index);
        }
        static public Match RegexMatch(this string item, string pattern) { return item.RegexMatch(pattern, 0); }
        static public Match RegexMatch(this string item, string pattern, int start_index)
        {
            return item.RegexMatch(pattern.GetRegexByPattern(), start_index);
        }
        static public Match RegexMatch(this string item, CachedRegex pattern)
        {
            return pattern.Match(item);
        }

        static public Match ReverseRegexMatch(this string item, string pattern) { return item.ReverseRegexMatch(pattern, item.GetFinalIndex()); }
        static public Match ReverseRegexMatch(this string item, string pattern, int start_index)
        {
            return item.RegexMatch(pattern.GetReverseRegexByPattern(), start_index);
        }

        static public MatchCollection RegexMatches(this string item, Regex pattern)
        {
            return pattern.Matches(item ?? "");
        }
        static public MatchCollection RegexMatches(this string item, string pattern)
        {
            return item.RegexMatches(pattern.GetRegexByPattern());
        }
        static public MatchCollection RegexMatches(this string item, CachedRegex pattern)
        {
            return pattern.Matches(item);
        }
    }
}