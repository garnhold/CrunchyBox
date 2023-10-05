using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Character_Set : TokenPattern_Character
    {
        private HashSet<char> characters;

        protected override bool IsCharacter(char character)
        {
            if (characters.Contains(character))
                return true;

            return false;
        }

        public TokenPattern_Character_Set(IEnumerable<char> c)
        {
            characters = c.ToHashSet();
        }

        public override IEnumerable<char> GetEntrys()
        {
            return characters;
        }
    }
}