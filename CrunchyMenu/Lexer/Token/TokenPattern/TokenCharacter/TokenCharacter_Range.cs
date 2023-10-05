using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenCharacter_Range : TokenCharacter
    {
        private char first;
        private char last;

        public TokenCharacter_Range(char f, char l)
        {
            first = f;
            last = l;
        }

        public override bool Is(char character)
        {
            if (first <= character && character <= last)
                return true;

            return false;
        }

        public override IEnumerable<char> GetEntrys()
        {
            for (char character = first; character <= last; character++)
                yield return character;
        }
    }
}