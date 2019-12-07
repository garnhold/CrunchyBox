using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    public class CachedRegexReplaceMatchCollection : IEnumerable<CachedRegexReplaceMatch>
    {
        private string remainder;
        private List<CachedRegexReplaceMatch> replace_matchs;

        public CachedRegexReplaceMatchCollection(string input, MatchCollection matchs)
        {
            int index = 0;

            replace_matchs = new List<CachedRegexReplaceMatch>();
            foreach (Match match in matchs)
            {
                replace_matchs.Add(new CachedRegexReplaceMatch(match, input.SubSection(index, match.Index)));

                index = match.Index + match.Length;
            }

            remainder = input.Substring(index);
        }

        public string Replace(string replacement)
        {
            StringBuilder string_builder = new StringBuilder();

            replace_matchs.Process(r => r.AppendTo(string_builder, replacement));
            string_builder.Append(remainder);

            return string_builder.ToString();
        }

        public string Replace(MatchEvaluator match_evaluator)
        {
            StringBuilder string_builder = new StringBuilder();

            replace_matchs.Process(r => r.AppendTo(string_builder, match_evaluator));
            string_builder.Append(remainder);

            return string_builder.ToString();
        }

        public IEnumerator<CachedRegexReplaceMatch> GetEnumerator()
        {
            return replace_matchs.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}