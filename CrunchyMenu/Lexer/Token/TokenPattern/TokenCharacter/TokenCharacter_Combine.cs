using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenCharacter_Combine : TokenCharacter
    {
        private List<TokenCharacter> characters;

        public TokenCharacter_Combine(IEnumerable<TokenCharacter> c)
        {
            characters = c.ToList();
        }

        public TokenCharacter_Combine(params TokenCharacter[] c) : this((IEnumerable<TokenCharacter>)c) { }

        public override bool Is(char c)
        {
            foreach (TokenCharacter character in characters)
            {
                if (character.Is(c))
                    return true;
            }

            return false;
        }

        public override IEnumerable<char> GetEntrys()
        {
            foreach (TokenCharacter character in characters)
            {
                foreach (char entry in character.GetEntrys())
                    yield return entry;
            }
        }
    }
}