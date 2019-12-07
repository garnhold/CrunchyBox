using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    public class CachedRegex
    {
        private Regex regex;

        private OperationCache<bool, string> is_match_cache;
        private OperationCache<Match, string> match_cache;

        private OperationCache<MatchCollection, string> matches_cache;
        private OperationCache<CachedRegexReplaceMatchCollection, string> replace_cache;

        public CachedRegex(Regex r)
        {
            regex = r;

            is_match_cache = new OperationCache<bool, string>("is_match_cache", delegate(string input) {
                return input.RegexIsMatch(regex);
            });
            match_cache = new OperationCache<Match, string>("match_cache", delegate(string input) {
                return input.RegexMatch(regex);
            });

            matches_cache = new OperationCache<MatchCollection, string>("matches_cache", delegate(string input) {
                return input.RegexMatches(regex);
            });
            replace_cache = new OperationCache<CachedRegexReplaceMatchCollection, string>("replace_cache", delegate(string input) {
                return new CachedRegexReplaceMatchCollection(input, Matches(input));
            });
        }

        public void Clear()
        {
            is_match_cache.Clear();
            match_cache.Clear();

            matches_cache.Clear();
            replace_cache.Clear();
        }

        public bool IsMatch(string input)
        {
            return is_match_cache.Fetch(input);
        }

        public Match Match(string input)
        {
            return match_cache.Fetch(input);
        }

        public MatchCollection Matches(string input)
        {
            return matches_cache.Fetch(input);
        }

        public string Replace(string input, string replacement)
        {
            return replace_cache.Fetch(input).Replace(replacement);
        }

        public string Replace(string input, MatchEvaluator match_evaluator)
        {
            return replace_cache.Fetch(input).Replace(match_evaluator);
        }
    }
}