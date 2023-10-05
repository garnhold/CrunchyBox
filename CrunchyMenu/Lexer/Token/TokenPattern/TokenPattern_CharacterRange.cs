using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_CharacterRange : TokenPattern
    {
        private char first_character;
        private char last_character;

        public TokenPattern_CharacterRange(char f, char l)
        {
            first_character = f;
            last_character = l;
        }

        public override int Detect(string text, int index)
        {
            if (index < text.Length)
            {
                char character = text[index];

                if (first_character <= character && character <= last_character)
                    return index + 1;
            }

            return -1;
        }

        public override IEnumerable<char> GetEntrys()
        {
            for (char character = first_character; character <= last_character; character++)
                yield return character;
        }
    }
}