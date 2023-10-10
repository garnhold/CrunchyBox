using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Sequence : TokenPattern
    {
        private List<TokenPattern> patterns;

        public TokenPattern_Sequence(IEnumerable<TokenPattern> p)
        {
            patterns = p.ToList();
        }

        public override int Detect(string text, int index)
        {
            foreach (TokenPattern pattern in patterns)
            {
                int new_index = pattern.Detect(text, index);

                if (new_index == -1)
                    return -1;

                index = new_index;
            }

            return index;
        }

        public override IEnumerable<char> GetEntrys()
        {
            foreach (TokenPattern pattern in patterns)
            {
                foreach (char entry in pattern.GetEntrys())
                    yield return entry;

                if (pattern.IsRequired())
                    yield break;
            }
        }

        public override string GetPsuedoRegEx()
        {
            return patterns
                .Convert(p => p.GetPsuedoRegEx())
                .Join("");
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
                TokenPattern last = simplified_patterns.GetLast();

                if (current != null)
                {
                    if (last != null && last.TryAppend(pattern, out TokenPattern combined))
                        simplified_patterns.SetLast(combined.Simplify());
                    else
                        simplified_patterns.Add(current);
                }
            }

            if (simplified_patterns.AreElementsEqual(patterns))
            {
                output = null;
                return false;
            }

            output = new TokenPattern_Sequence(simplified_patterns);
            return true;
        }
    }
}