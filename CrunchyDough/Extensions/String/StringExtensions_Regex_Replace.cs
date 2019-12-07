using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Regex_Replace
    {
        static public string RegexReplace(this string item, Regex pattern, MatchEvaluator match_evaluator)
        {
            return pattern.Replace(item ?? "", match_evaluator);
        }
        static public string RegexReplace(this string item, string pattern, MatchEvaluator match_evaluator)
        {
            return item.RegexReplace(pattern.GetRegexByPattern(), match_evaluator);
        }
        static public string RegexReplace(this string item, CachedRegex pattern, MatchEvaluator match_evaluator)
        {
            return pattern.Replace(item, match_evaluator);
        }

        static public string RegexReplace(this string item, Regex pattern, string replacement)
        {
            return item.RegexReplace(pattern, delegate(Match match) {
                return replacement;
            });
        }
        static public string RegexReplace(this string item, string pattern, string replacement)
        {
            return item.RegexReplace(pattern.GetRegexByPattern(), replacement);
        }
        static public string RegexReplace(this string item, CachedRegex pattern, string replacement)
        {
            return item.RegexReplace(pattern, delegate(Match match) {
                return replacement;
            });
        }

        static public string RegexReplaceBlock(this string item, Regex pattern, MatchEvaluator match_evaluator)
        {
            return item.RegexReplace(pattern, delegate(Match match) {
                return item.PrepareBlockForInsert(match_evaluator(match), match.Index);
            });
        }
        static public string RegexReplaceBlock(this string item, string pattern, MatchEvaluator match_evaluator)
        {
            return item.RegexReplaceBlock(pattern.GetRegexByPattern(), match_evaluator);
        }
        static public string RegexReplaceBlock(this string item, CachedRegex pattern, MatchEvaluator match_evaluator)
        {
            return item.RegexReplace(pattern, delegate(Match match) {
                return item.PrepareBlockForInsert(match_evaluator(match), match.Index);
            });
        }

        static public string RegexReplaceBlock(this string item, Regex pattern, string block)
        {
            return item.RegexReplaceBlock(pattern, delegate(Match match) {
                return block;
            });
        }
        static public string RegexReplaceBlock(this string item, string pattern, string block)
        {
            return item.RegexReplaceBlock(pattern.GetRegexByPattern(), block);
        }
        static public string RegexReplaceBlock(this string item, CachedRegex pattern, string block)
        {
            return item.RegexReplaceBlock(pattern, delegate(Match match) {
                return block;
            });
        }
    }
}