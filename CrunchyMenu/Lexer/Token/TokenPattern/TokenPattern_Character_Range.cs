using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Character_Range : TokenPattern_Character
    {
        private char first_character;
        private char last_character;

        protected override bool IsCharacter(char character)
        {
            if (first_character <= character && character <= last_character)
                return true;

            return false;
        }

        public TokenPattern_Character_Range(char f, char l)
        {
            first_character = f;
            last_character = l;
        }

        public override IEnumerable<char> GetEntrys()
        {
            for (char character = first_character; character <= last_character; character++)
                yield return character;
        }
    }
}