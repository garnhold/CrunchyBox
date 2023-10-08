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
    }
}