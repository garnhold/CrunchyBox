using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Multiple : TokenPattern
    {
        private List<TokenPattern> patterns;

        public TokenPattern_Multiple(IEnumerable<TokenPattern> p)
        {
            patterns = p.ToList();
        }

        public override int Detect(string text, int index)
        {
            return patterns.FindHighestRating(p => p.Detect(text, index));
        }

        public override IEnumerable<char> GetEntrys()
        {
            foreach (TokenPattern pattern in patterns)
            {
                foreach (char entry in pattern.GetEntrys())
                    yield return entry;
            }
        }
    }
}