using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPatternCharacter_Range : TokenPatternCharacter
    {
        private char first_character;
        private char last_character;

        public TokenPatternCharacter_Range(char f, char l, int min, int max) : base(min, max)
        {
            first_character = f;
            last_character = l;
        }

        public override bool Is(char c)
        {
            if (first_character <= c && last_character >= c)
                return true;

            return false;
        }

        public override IEnumerable<char> GetEntrys()
        {
            for (char character = first_character; character <= last_character; character++)
                yield return character;
        }
    }
}