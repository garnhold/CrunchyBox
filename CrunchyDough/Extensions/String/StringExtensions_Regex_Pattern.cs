using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Regex_Pattern
    {
        static private OperationCache<Regex, string> GET_REGEX_BY_PATTERN = TextParsingCache.Get().NewOperationCache("GET_REGEX_BY_PATTERN", delegate(string pattern) {
            return new Regex(pattern, RegexOptions.Singleline);
        });
        static public Regex GetRegexByPattern(this string pattern)
        {
            return GET_REGEX_BY_PATTERN.Fetch(pattern);
        }

        static private OperationCache<Regex, string> GET_REVERSE_REGEX_BY_PATTERN = TextParsingCache.Get().NewOperationCache("GET_REVERSE_REGEX_BY_PATTERN", delegate(string pattern) {
            return new Regex(pattern, RegexOptions.Singleline | RegexOptions.RightToLeft);
        });
        static public Regex GetReverseRegexByPattern(this string pattern)
        {
            return GET_REVERSE_REGEX_BY_PATTERN.Fetch(pattern);
        }

        static private OperationCache<Regex, string> COMPILE_REGEX_FROM_PATTERN = TextParsingCache.Get().NewOperationCache("COMPILE_REGEX_FROM_PATTERN", delegate(string pattern) {
            return new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled);
        });
        static public Regex CompileRegexFromPattern(this string pattern)
        {
            return COMPILE_REGEX_FROM_PATTERN.Fetch(pattern);
        }

        static private OperationCache<Regex, string> COMPILE_REVERSE_REGEX_FROM_PATTERN = TextParsingCache.Get().NewOperationCache("COMPILE_REVERSE_REGEX_FROM_PATTERN", delegate(string pattern) {
            return new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.RightToLeft);
        });
        static public Regex CompileReverseRegexFromPattern(this string pattern)
        {
            return COMPILE_REVERSE_REGEX_FROM_PATTERN.Fetch(pattern);
        }

        static private OperationCache<CachedRegex, string> COMPILE_CACHED_REGEX_FROM_PATTERN = TextParsingCache.Get().NewOperationCache("COMPILE_CACHED_REGEX_FROM_PATTERN", delegate(string pattern) {
            return new CachedRegex(pattern.CompileRegexFromPattern());
        });
        static public CachedRegex CompileCachedRegexFromPattern(this string pattern)
        {
            return COMPILE_CACHED_REGEX_FROM_PATTERN.Fetch(pattern);
        }
    }
}