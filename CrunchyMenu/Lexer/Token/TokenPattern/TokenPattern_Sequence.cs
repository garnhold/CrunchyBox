using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Sequence : TokenPattern
    {
        private List<TokenPattern> token_patterns;

        public TokenPattern_Sequence(IEnumerable<TokenPattern> p)
        {
            token_patterns = p.ToList();
        }

        public TokenPattern_Sequence(params TokenPattern[] p) : this((IEnumerable<TokenPattern>)p) { }

        public override bool Detect(string text, int index, out int new_index)
        {
            new_index = index;

            foreach (TokenPattern pattern in token_patterns)
            {
                if (pattern.Detect(text, index, out new_index))
                    index = new_index;
                else
                    return false;
            }

            return true;
        }

        public override IEnumerable<char> GetEntrys()
        {
            yield return value.GetFirst();
        }
    }
}