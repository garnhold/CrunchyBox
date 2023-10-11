using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Any : TokenPattern
    {
        private List<TokenPattern> patterns;

        public TokenPattern_Any(IEnumerable<TokenPattern> p)
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

        public override string GetPsuedoRegEx()
        {
            return patterns
                .Convert(p => "(" + p.GetPsuedoRegEx() + ")")
                .Join("|");
        }

        public override bool TrySimplify(out TokenPattern output)
        {
            if (patterns.Count == 0)
            {
                output = null;
                return true;
            }

            if (patterns.Count == 1)
            {
                output = patterns.GetFirst();
                return true;
            }

            List<TokenPattern> simplified_patterns = new List<TokenPattern>();

            foreach (TokenPattern pattern in patterns)
            {
                TokenPattern current = pattern.Simplify();

                if (current != null)
                    simplified_patterns.Add(current);
            }

            if (simplified_patterns.AreElementsEqual(patterns))
            {
                output = null;
                return false;
            }

            output = new TokenPattern_Any(simplified_patterns);
            return true;
        }
    }
}