using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_CharacterSet : TokenPattern
    {
        private HashSet<char> characters;

        public TokenPattern_CharacterSet(IEnumerable<char> c)
        {
            characters = c.ToHashSet();
        }

        public override int Detect(string text, int index)
        {
            if (index < text.Length)
            {
                if (characters.Contains(text[index]))
                    return index + 1;
            }

            return -1;
        }

        public override IEnumerable<char> GetEntrys()
        {
            return characters;
        }

        public IEnumerable<char> GetCharacters()
        {
            return characters;
        }
    }
}