using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenCharacterSet
    {
        private char[] characters;
        private bool[] character_map;

        static public implicit operator TokenCharacterSet(char character)
        {
            return new TokenCharacterSet(character);
        }

        public TokenCharacterSet(IEnumerable<char> c)
        {
            characters = c.ToArray();
            character_map = new bool[char.MaxValue];

            characters.Process(z => character_map[z] = true);
        }

        public TokenCharacterSet(params char[] c) : this((IEnumerable<char>)c) { }

        public bool Is(char c)
        {
            if (character_map[c])
                return true;

            return false;
        }

        public IEnumerable<char> GetCharacters()
        {
            return characters;
        }
    }
}