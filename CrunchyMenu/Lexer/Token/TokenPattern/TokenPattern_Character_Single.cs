using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Character_Single : TokenPattern_Character
    {
        private char character;

        protected override bool IsCharacter(char c)
        {
            if (character == c)
                return true;

            return false;
        }

        public TokenPattern_Character_Single(char c)
        {
            character = c;
        }

        public override IEnumerable<char> GetEntrys()
        {
            yield return character;
        }
    }
}