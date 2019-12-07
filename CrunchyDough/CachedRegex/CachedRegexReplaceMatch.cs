using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    public class CachedRegexReplaceMatch
    {
        private Match match;
        private string pre_match_string;

        public CachedRegexReplaceMatch(Match m, string s)
        {
            match = m;
            pre_match_string = s;
        }

        public void AppendTo(StringBuilder string_builder, string replacement)
        {
            string_builder.Append(pre_match_string);
            string_builder.Append(replacement);
        }

        public void AppendTo(StringBuilder string_builder, MatchEvaluator match_evaluator)
        {
            AppendTo(string_builder, match_evaluator(match));
        }

        public Match GetMatch()
        {
            return match;
        }

        public string GetPreMatchString()
        {
            return pre_match_string;
        }
    }
}