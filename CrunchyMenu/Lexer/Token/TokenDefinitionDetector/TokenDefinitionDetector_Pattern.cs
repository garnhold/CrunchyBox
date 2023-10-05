using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinitionDetector_Pattern : TokenDefinitionDetector
    {
        private TokenPattern pattern;

        public TokenDefinitionDetector_Pattern(TokenPattern p)
        {
            pattern = p;
        }

        public override int Detect(string text, int index)
        {
            return pattern.Detect(text, index);
        }

        public override IEnumerable<char> GetEntrys()
        {
            return pattern.GetEntrys();
        }
    }
}