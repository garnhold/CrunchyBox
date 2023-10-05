using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPatternCharacter_Static : TokenPatternCharacter
    {
        private char character;

        public TokenPatternCharacter_Static(char c, int min, int max) : base(min, max)
        {
            character = c;
        }

        public override bool Is(char c)
        {
            if (character == c)
                return true;

            return false;
        }

        public override IEnumerable<char> GetEntrys()
        {
            yield return character;
        }
    }
}