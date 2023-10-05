using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Character : TokenPattern
    {
        private char character;

        public TokenPattern_Character(char c)
        {
            character = c;
        }

        public override int Detect(string text, int index)
        {
            if (index < text.Length)
            {
                if (character == text[index])
                    return index + 1;
            }

            return -1;
        }

        public override IEnumerable<char> GetEntrys()
        {
            yield return character;
        }

        public char GetCharacter()
        {
            return character;
        }
    }
}